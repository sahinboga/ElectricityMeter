using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

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
				var IMax = meters[i].Active != 0 ? Math.Round(((meters[i].Active - meters[0].Active) * 0.2) + meters[0].Inductive,3) : .0f;
				var IFark = Math.Round(meters[i].Inductive - IMax,3);

				// Capacitive için max ve fark
				var CMax = meters[i].Active != 0 ? Math.Round(((meters[i].Active - meters[0].Active) * 0.15) + meters[0].Capacitive,3) : .0f;
				var CFark = Math.Round(meters[i].Capacitive - CMax,3);

				if (i == 1)
				{
					mt.Add(new MeterDetailDto
					{
						Id=1,
						ReadDate = meters[0].ReadDate,
						Active = meters[0].Active,
						Inductive=meters[0].Inductive,
						Capacitive=meters[0].Capacitive,
						CTotalRate=Math.Round((meters[0].Capacitive/meters[0].Active)*100,3),
						ITotalRate=Math.Round((meters[0].Inductive/meters[0].Active)*100,3),
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
					ILimitActive = (meters[i].Active != 0 ? Math.Round(((meters[i].Inductive - meters[0].Inductive) / 0.2 + meters[0].Active),3) : .0f),
					IDailyRate = (meters[i].Active != 0 ? Math.Round(((meters[i].Inductive - meters[i - 1].Inductive) / (meters[i].Active - meters[i - 1].Active)),3) : .0f),
					ITotalRate =(meters[i].Active != 0 ? Math.Round(((meters[i].Inductive - meters[0].Inductive) / (meters[i].Active - meters[0].Active)),3): .0f),

					// Capacitive için hesaplamalar
					Capacitive = meters[i].Capacitive,
					CStatu = meters[i].Active != 0 ? (CFark < 0 ? "Normal" : "Cezada") : "0.00",
					CLimitActive = (meters[i].Active != 0 ? Math.Round(((meters[i].Capacitive - meters[0].Capacitive) / 0.15 + meters[0].Active),3) : .0f),
					CDailyRate = (meters[i].Active != 0 ? Math.Round(((meters[i].Capacitive - meters[i - 1].Capacitive) / (meters[i].Active - meters[i - 1].Active)),3) : .0f),
					CTotalRate = (meters[i].Active != 0 ? Math.Round(((meters[i].Capacitive - meters[0].Capacitive) / (meters[i].Active - meters[0].Active)),3) : .0f),
					
					// Günlük hesaplamalar
					ADailyConsumption = Math.Round((meters[i].Active - meters[i - 1].Active) * (meter.Data.Multipy),3),
					IDailyConsumption = Math.Round((meters[i].Inductive - meters[i - 1].Inductive) * (meter.Data.Multipy),3),
					CDailyConsumption = Math.Round((meters[i].Capacitive - meters[i - 1].Capacitive) * (meter.Data.Multipy),3)

				}) ;
			}
			return new SuccessDataResult<List<MeterDetailDto>>(mt, Messages.Listed);
		}

		public IDataResult<MeterDetail> GetById(int meterDetailId)
		{
			var meter = _meterDetailDal.GetById(m => m.Id == meterDetailId);
			return new SuccessDataResult<MeterDetail>(meter);
		}

		public IDataResult<List<MeterDto>> GetWithDetails()
		{
			var meters = _meterService.GetAllWithDetails().Data;
			
			foreach (var meter in meters)
			{
				var details=this.GetAllWithDetails(meter.Id).Data;
				details.Reverse();
				var lastDetail = details.FirstOrDefault();
				if (lastDetail != null)
				{
					meter.IDailyRate = lastDetail.IDailyRate;
					meter.ITotalRate = lastDetail.ITotalRate;
					meter.CDailyRate = lastDetail.CDailyRate;
					meter.CTotalRate = lastDetail.CTotalRate;
					meter.ADailyConsumption = lastDetail.ADailyConsumption;
					meter.CDailyConsumption = lastDetail.CDailyConsumption;
					meter.IDailyConsumption = lastDetail.IDailyConsumption;
				}
			}
			return new SuccessDataResult<List<MeterDto>>(meters);
		}

		public IResult Update(MeterDetail meter)
		{
			_meterDetailDal.Update(meter);
			return new SuccessResult(Messages.Updated);
		}
	}
}
