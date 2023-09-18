using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace Array_Couples.Test
{
    public class ArrayCouplesTest
    {
        public static IEnumerable<object[]> SumData => new List<object[]>
        {
            new object[] { 5, 4, 6, 7, 7, 6, 4, 5 },
            new object[] { 1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 2, 1 },
            new object[] { 4, 5, 1, 4, 5, 4, 4, 1 }
        };

        [Theory]
        [InlineData(new int[] { 5, 4, 6, 7, 7, 6, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { 4, 5, 1, 4, 5, 4, 4, 1 })]
        public void CheckElementTestYes(int[] arr)
        {
            #region Arrange

            string expected = "yes";

            #endregion

            #region Act

            var result = Program.ArrayCouples(arr);

            #endregion

            #region Assert

            Assert.Equal(expected, result);

            #endregion
        }

        [Theory]
        [InlineData(new int[] { 6, 2, 2, 6, 5, 14, 14, 1 })]
        public void CheckElementTestNo(int[] arr)
        {
            #region Arrange

            var expected = "5,14,14,1";

            #endregion

            #region Act

            var result = Program.ArrayCouples(arr);

            #endregion

            #region Assert

            Assert.Equal(expected, result);

            #endregion
        }

        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2, 3, 3 })]
        public void CheckElementTestNo2(int[] arr)
        {
            #region Arrange

            var expected = "3,3";

            #endregion

            #region Act

            var result = Program.ArrayCouples(arr);

            #endregion

            #region Assert

            Assert.Equal(expected, result);

            #endregion
        }
    }
}