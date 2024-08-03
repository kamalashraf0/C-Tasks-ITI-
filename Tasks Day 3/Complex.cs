namespace Tasks_Day_3
{
    class Complex
    {
        #region Data
        private int real;
        private int img;
        #endregion
        #region Setters& Getters
        public void SetReal(int _real)
        {

            real = _real;
        }
        public void SetImg(int _img)
        {
            img = _img;
        }
        public int GetReal()
        {
            return real;
        }
        public int GetImg()
        {
            return img;
        }
        #endregion
        #region Print
        public string Print()
        {
            if (real == 0 && img == 0)
                return "0";
            if (real == 0)
                return (img == 1) ? "i" : (img == -1) ? "-i" : $"{img}i";
            if (img == 0)
                return $"{real}";
            if (img == 1)
                return $"{real}+i";
            if (img == -1)
                return $"{real}-i";
            return (img > 0) ? $"{real}+{img}i" : $"{real}{img}i";
        }
        #endregion

        #region Add 2 Complex #'s

        public Complex Add(Complex value)
        {
            Complex retVal = new Complex();
            retVal.real = real + value.real;
            retVal.img = img + value.img;
            return retVal;
        }
        #endregion
    }
}
