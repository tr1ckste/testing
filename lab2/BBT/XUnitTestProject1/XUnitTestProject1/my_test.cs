using System;
using Xunit;
using IIG.BinaryFlag;


namespace BinaryFlagTests
{

    public class Tests
    {
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
            MultipleBinaryFlag actual = new MultipleBinaryFlag(17179868704);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MaxValueDec()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(17179868704 - 1);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MaxValueInc()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(17179868704 + 1));
        }

        [Fact]
        public void MinValue()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(2);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MinValueInc()
        {
            MultipleBinaryFlag actual = new MultipleBinaryFlag(2 + 1);
            MultipleBinaryFlag expected = null;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void MinValueDec()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(2 - 1));
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
    }
}
