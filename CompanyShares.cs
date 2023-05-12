namespace StockAccountManagement{
    class CompanyShares{
        public string stockSymbol ="";
        public int shareCount;

        DateTime transactionTime;

        public CompanyShares(string symbol, int share){
            stockSymbol=symbol;
            shareCount=share;
            transactionTime=DateTime.Now;
        }
        public void AddCompany(){
            StockAccount.companyShares.Add(this);
        }
    }
}