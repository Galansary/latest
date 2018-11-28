using Xunit;

namespace XUnitTestProject1
{
    public class BloodpressureCategoryTest
    {
      
            [Fact]
            public void BPCategory_low()
            {
                //arrange 
                BPCalculator.BloodPressure test = new BPCalculator.BloodPressure() { Systolic = 80, Diastolic = 50 };            //Act
                BPCalculator.BPCategory actual = test.Category;
                //asert
                Assert.Equal(BPCalculator.BPCategory.Low, actual);
            }
            [Fact]
            public void BPCategory_ideal()
            {
                //Arrange
                BPCalculator.BloodPressure test = new BPCalculator.BloodPressure() { Systolic = 110, Diastolic = 70 }; ;
                //Act
                BPCalculator.BPCategory actual = test.Category;
                //Assert
                Assert.Equal(BPCalculator.BPCategory.Normal, actual);
            }
            [Fact]
            public void BPCategory_Prehigh()
            {
                //Arrange
                BPCalculator.BloodPressure test = new BPCalculator.BloodPressure() { Systolic = 130, Diastolic = 80 }; ;
                //Act
                BPCalculator.BPCategory actual = test.Category;
                //Assert
                Assert.Equal(BPCalculator.BPCategory.PreHigh, actual);
            }
            [Fact]
            public void BPCategory_high()
            {
                //Arrange
                BPCalculator.BloodPressure test = new BPCalculator.BloodPressure() { Systolic = 140, Diastolic = 95 }; ;
                //Act
                BPCalculator.BPCategory actual = test.Category;
                //Assert
                Assert.Equal(BPCalculator.BPCategory.High, actual);
            }
            [Fact]
            public void BPCategory_unkown()
            {
                //Arrange
                BPCalculator.BloodPressure test = new BPCalculator.BloodPressure() { Systolic = 140, Diastolic = 60 }; ;
                //Act
                BPCalculator.BPCategory actual = test.Category;
                //Assert
                Assert.Equal(BPCalculator.BPCategory.Abnormal, actual);
            }
        }
    }

