using System;
using Xunit;
using IIG.BinaryFlag;


namespace BinaryFlagTests
{

    public class Tests
    {
        private ulong max = 17179868704;
        private uint min = 2;
        private uint flagMin = 0;

        [Fact]
        public void GetFlagIfTrue()
        {
            MultipleBinaryFlag myBinaryFlag = new MultipleBinaryFlag(3);
            bool? actual = myBinaryFlag.GetFlag();
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFlagIfFalse()
        {
            MultipleBinaryFlag myBinaryFlag = new MultipleBinaryFlag(3);
            myBinaryFlag.ResetFlag(2);
            bool? actual = myBinaryFlag.GetFlag();
            bool expected = false;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ResetFlag()
        {
            MultipleBinaryFlag myBinaryFlag = new MultipleBinaryFlag(3);
            myBinaryFlag.ResetFlag(2);
            myBinaryFlag.SetFlag(2);
            bool? actual = myBinaryFlag.GetFlag();
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DisposeNull()
        {
            MultipleBinaryFlag myBinaryFlag = new MultipleBinaryFlag(3);
            bool? expected = null;
            myBinaryFlag.Dispose();
            bool? actual = myBinaryFlag.GetFlag();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxValue()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MaxValueDec()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max - 1);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MaxValueInc()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(this.max + 1));
        }

        [Fact]
        public void MinValue()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.min);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MinValueInc()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.min + 1);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MinValueDec()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(this.min - 1));
        }

        [Fact]
        public void ResetTest()
        {
            MultipleBinaryFlag myBinaryFlag = new MultipleBinaryFlag(3);
            myBinaryFlag.ResetFlag(1);
            string expected = "TFT";
            string actual = myBinaryFlag.ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetTest()
        {
            MultipleBinaryFlag myBinaryFlag = new MultipleBinaryFlag(3, false);
            myBinaryFlag.SetFlag(1);
            string expected = "FTF";
            string actual = myBinaryFlag.ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxValueSetInc()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.SetFlag(this.max));
        }

        [Fact]
        public void MaxValueSet()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.SetFlag(this.max - 1);
            Assert.NotNull(actual);
        }

        [Fact]
        public void MaxValueSetDec()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.SetFlag(this.max - 2);
            Assert.NotNull(actual);
        }

        [Fact]
        public void MinValueSetInc()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.SetFlag(this.flagMin + 1);
            Assert.NotNull(actual);
        }

        [Fact]
        public void MinValueSet()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.SetFlag(this.flagMin);
            Assert.NotNull(actual);
        }

        [Fact]
        public void MaxValueResetInc()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.ResetFlag(this.max));
        }

        [Fact]
        public void MaxValueReset()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.ResetFlag(this.max - 1);
            Assert.NotNull(actual);
        }

        [Fact]
        public void MaxValueResetDec()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.ResetFlag(this.max - 2);
            Assert.NotNull(actual);
        }

        [Fact]
        public void MinValueResetInc()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.ResetFlag(this.flagMin + 1);
            Assert.NotNull(actual);
        }

        [Fact]
        public void MinValuereet()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(this.max);
            actual.ResetFlag(this.flagMin);
            Assert.NotNull(actual);
        }
    }
}
