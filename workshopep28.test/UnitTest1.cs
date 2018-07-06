using System;
using FluentAssertions;
using FluentAssertions.Collections;
using Moq;
using Xunit;

namespace workshopep28.test {
    public class UnitTest1 {

        [Theory (DisplayName = "คะแนนสามารถตัดเกรดได้สำเร็จ")]
        [InlineData (99, "A")]
        [InlineData (81, "A")]
        [InlineData (85, "A")]
        [InlineData (80, "B")]
        [InlineData (65, "C")]
        [InlineData (54, "D")]
        [InlineData (32, "F")]
        [InlineData (0, "F")]
        [InlineData (120, "A")]
        [InlineData (-30, "F")]
        public void CalCulatorSuccess (int input, string expectedResult) {
            var cal = new Calculator ();

            var x = cal.GradeCalculator (input);

            x.Should ().Be (expectedResult);
        }
    }
}