using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class MeterDetailManager : IMeterDetailService
	{
		IMeterDetailDal _meterDetailDal;
		IMeterService _meterService;

		public MeterDetailManager(IMeterDetailDal meterDetailDal,IMeterService meterService)
		{
			_meterDetailDal = meterDetailDal;
			_meterService = meterService;
		}

		public IResult Add(MeterDetail meter)
		{
			_meterDetailDal.Add(meter);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(MeterDetail meter)
		{
			_meterDetailDal.Delete(meter);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<MeterDetail>> GetAll()
		{
			return new SuccessDataResult<List<MeterDetail>>(_meterDetailDal.GetAll(), Messages.Listed);
		}

		public IDataResult<List<MeterDetailDto>> GetAllWithDetails(int meterId)
		{
			var meters = _meterDetailDal.GetAll(md => md.MeterId==meterId);
			var meter = _meterService.GetById(meterId);
			

			// sayacın tüm hesaplanmış  verilerini tutan liste
			var mt = new List<MeterDetailDto>();

			for(var i=1; i<meters.Count;i++)
			{
				// Inductive için max ve fark
				var IMax = meters[i].Active != 0 ? ((meters[i].Active - meters[0].Active) * 0.2) + meters[0].Inductive : .0f;
				var IFark = meters[i].Inductive - IMax;

				// Capacitive için max ve fark
				var CMax = meters[i].Active != 0 ? ((meters[i].Active - meters[0].Active) * 0.15) + meters[0].Capacitive : .0f;
				var CFark = meters[i].Capacitive - CMax;

				if (i == 1)
				{
					mt.Add(new MeterDetailDto
					{
						Id=1,
						ReadDate = meters[0].ReadDate,
						Active = meters[0].Active,
						Inductive=meters[0].Inductive,
						Capacitive=meters[0].Capacitive,
						CTotalRate=(meters[0].Capacitive/meters[0].Active)*100,
						ITotalRate=(meters[0].Inductive/meters[0].Active)*100
					});
				}

				mt.Add(new MeterDetailDto
				{
					Id = i+1,
					ReadDate =meters[i].ReadDate,
					Active = meters[i].Active,

					// Inductive için hesaplamalar
					Inductive = meters[i].Inductive,
					IStatu = meters[i].Active != 0 ? (IFark < 0 ? "Normal" : "Cezada") : "0.00",
					ILimitActive = (meters[i].Active != 0 ? ((meters[i].Inductive - meters[0].Inductive) / 0.2 + meters[0].Active) : .0f),
					IDailyRate = (meters[i].Active != 0 ? ((meters[i].Inductive - meters[i - 1].Inductive) / (meters[i].Active - meters[i - 1].Active)) : .0f),
					ITotalRate =(meters[i].Active != 0 ? ((meters[i].Inductive - meters[0].Inductive) / (meters[i].Active - meters[0].Active)) : .0f),
					
					// Capacitive için hesaplamalar
					Capacitive = meters[i].Capacitive,
					CStatu = meters[i].Active != 0 ? (CFark < 0 ? "Normal" : "Cezada") : "0.00",
					CLimitActive = (meters[i].Active != 0 ? ((meters[i].Capacitive - meters[0].Capacitive) / 0.15 + meters[0].Active) : .0f),
					CDailyRate = (meters[i].Active != 0 ? ((meters[i].Capacitive - meters[i - 1].Capacitive) / (meters[i].Active - meters[i - 1].Active)) : .0f),
					CTotalRate = (meters[i].Active != 0 ? ((meters[i].Capacitive - meters[0].Capacitive) / (meters[i].Active - meters[0].Active)) : .0f),
					
					// Günlük hesaplamalar
					ADailyConsumption = (meters[i].Active - meters[i - 1].Active) * (meter.Data.Multipy),
					IDailyConsumption = (meters[i].Inductive - meters[i - 1].Inductive) * (meter.Data.Multipy),
					CDailyConsumption = (meters[i].Capacitive - meters[i - 1].Capacitive) * (meter.Data.Multipy)

				}) ;
			}
			return new SuccessDataResult<List<MeterDetailDto>>(mt, Messages.Listed);
		}

		public IDataResult<MeterDetail> GetById(int meterDetailId)
		{
			var meter = _meterDetailDal.GetById(m => m.Id == meterDetailId);
			return new SuccessDataResult<MeterDetail>(meter);
		}

		public IResult Update(MeterDetail meter)
		{
			_meterDetailDal.Update(meter);
			return new SuccessResult(Messages.Updated);
		}
	}
}
