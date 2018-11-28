using System;
using System.ComponentModel.DataAnnotations;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name = "Low Blood Pressure")] Low,
        [Display(Name = "Normal Blood Pressure")] Normal,
        [Display(Name = "Pre-High Blood Pressure")] PreHigh,
        [Display(Name = "High Blood Pressure")] High,
        [Display(Name = "Abnormal Blood Pressure Reading")] Abnormal,
    }

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG

        // calculate BP category
        public BPCategory Category
        {
            get
            {
                // calculate BP category based limits
                if (Systolic >= SystolicMin && Systolic < 90 && Diastolic > DiastolicMin && Diastolic < 60)
                {
                    return BPCategory.Low;
                }
                if (Systolic >= 90 && Systolic < 120 && Diastolic >= 60 && Diastolic < 80)
                {
                    return BPCategory.Normal;
                }
                if (Systolic >= 120 && Systolic < 140 && Diastolic >= 80 && Diastolic < 90)
                {
                    return BPCategory.PreHigh;
                }
                if (Systolic >= 140 && Systolic < SystolicMax && Diastolic >= 90 && Diastolic < DiastolicMax)
                {
                    return BPCategory.High;
                }
                else
                {
                    return BPCategory.Abnormal;

                }
            }
        }
    }
}