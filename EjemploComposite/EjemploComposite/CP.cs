namespace EjemploComposite
{
    public class CP
    {
        public string _cid { get; set; }
        public decimal _dEnero { get; set; }
        public decimal _dFebrero { get; set; }
      
        public CP(string _cid, decimal _dEnero, decimal _dFebrero)
        {
            this._cid = _cid;
            this._dEnero = _dEnero;
            this._dFebrero = _dFebrero;
        }
    }
}
