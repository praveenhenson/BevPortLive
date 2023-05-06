using System.Xml.Linq;

namespace BevPort.Helpers
{
    #region All the URLs of the Application - HIMANSHU MISHRA
    public class BaseURL
    {
        private string _GetUserByEmail = "api/GetUserByEmail?code=eP9GuxaFm7K0KbbRLu5plJsqXJwciMuGGt4Btyu2K0NeAzFuLlGg_A==";
        public string GetUserByEmail { get{return _GetUserByEmail; }}

        private string _CreateUser = "api/GetUserByEmail?code=eP9GuxaFm7K0KbbRLu5plJsqXJwciMuGGt4Btyu2K0NeAzFuLlGg_A==";
        public string CreateUser { get { return _CreateUser; } }

        private string _UserDetails = "api/UserDetails?code=9YgziEOvtjaGZUrs6eWCnzU7EqknNxyI_9uVcrNTztd7AzFud8hXWA==";
        public string UserDetails { get { return _UserDetails; } }

        private string _UserBankDetails = "api/UserBankDetails?code=N1Sxiew5EH-TTX9lVUdHLr3UT5n5N4Gjby9OfHYEfjxMAzFuoC5RCQ==";
        public string UserBankDetails { get { return _UserBankDetails; } }

        private string _UserPaymentDetails = "api/UpdatePayment?code=HHy_1YG8E-fiWZfTHX7dSCzuQd2QPhxqv2czc5CcokHxAzFuO1c0jw==";
        public string UserPaymentDetails { get { return _UserPaymentDetails; } }


        private string _UpdatePassword = "api/UpdatePassword?code=xMNdVzCTgrtdAEETDwaJ2amNqsLJpovNFmyWK3CAJuVXAzFu5kmC0A==";
        public string UpdatePassword { get { return _UpdatePassword; } }

        private string _Login = "api/Login?code=6IJr4jvQgoqoxE4jN2311vAWXV7pdKfrL6XAf1oj3pMjAzFuKsko9w==";
        public string Login { get { return _Login; } }

        private string _senderEmailAddress = "info@bevport.com";
        //private string _senderEmailAddress = "mcaashu214@gmail.com";
        public string senderEmailAddress { get { return _senderEmailAddress; } }

        private string _senderEmailName = "BevPort";
        public string senderEmailName { get { return _senderEmailName; } }

        private string _senderPassword = "mphctlloxyohdnve";
        //private string _senderPassword = "seqarpfwqqufvues";
        public string senderPassword { get { return _senderPassword; } }

        private string _CreateContactUs = "api/CreateContactUs?code=CSkfQ05CLxmF469MmzByr46HCcsB27-wkQtsab49GyBuAzFuRU4R1A==";
        public string CreateContactUs { get { return _CreateContactUs; } }


        private string _CreateBrand = "api/CreateBrand?code=jV8wBLx7O-oEsxPIKZq708_MRQY_RDTQA76pm4SRqWotAzFugUNBeA==";
        public string CreateBrand { get { return _CreateBrand; } }

        private string _GetBrandsByUserID = "api/GetBrandsByUserID?code=SMQdTjrEcdoCmTxCspsjUNEu40kkuTb8FwjtnoN3LZ-sAzFu2HCHWg==";
        public string GetBrandsByUserID { get { return _GetBrandsByUserID; } }

        private string _CheckBrandName = "api/GetBrandByName?code=s5GAYAyBA4LMTVr2mC1KOJXm_9nVxrGLRLAY0RklAXg4AzFuFGXmVQ==";
        public string CheckBrandName { get { return _CheckBrandName; } }

        private string _ArchiveUnarchiveBrand = "api/ArchiveUnarchiveBrand?code=Mv8126U41OVrweQOe_qQQ6yvY_HmVBFNL-HnKmudiRHuAzFuwn9ITw==";
        public string ArchiveUnarchiveBrand { get { return _ArchiveUnarchiveBrand; } }

        private string _ChangePassword = "api/ChangePassword?code=J6-OQYVuaeaL48eggx5KgNIQrnno40D4tsCCCHxgS2IvAzFutCP2Dw==";
        public string ChangePassword { get { return _ChangePassword; } }

        private string _GetUserByID = "api/GetUserByID?code=n3X2Y58kk7ojduyLVmT7YK49fEP02dd_x-L2214EaIQOAzFubWFFfA==";
        public string GetUserByID { get { return _GetUserByID; } }

        private string _UpdatePersonalInfo = "api/UpdatePersonalInfo?code=KXRHC5zfGDJ1VD-5ScPluJClDTpRg65lPrupRHhAmmm6AzFu6ZlS6g==";
        public string UpdatePersonalInfo { get { return _UpdatePersonalInfo; } }

        private string _CreateBrandMediaInfo = "api/CreateBrandMediaInfo?code=zYN4yn4zQnvz4ynOV7-CPxQ5eHhZ5-TnphlDybe5QzMOAzFuOP7SCw==";
        public string CreateBrandMediaInfo { get { return _CreateBrandMediaInfo; } }

        private string _CreateProduct = "api/CreateProduct?code=azVK66Rs73EOo15N9QMi8aOTAbQeCFzAeyrRCn_OCi96AzFuCW46jw==";
        public string CreateProduct { get { return _CreateProduct; } }

        private string _CreateProductMediaInfo = "api/CreateProductMediaInfo?code=cwMZzzf95Xl4vcZQ-_0RaEwyxQxsHXcIBEKA-kcHRjT2AzFuCiobqw==";
        public string CreateProductMediaInfo { get { return _CreateProductMediaInfo; } }

        private string _GetProductsByBrandID = "api/GetProductsByBrandID?code=NWAoZEgSl2KlwZHyBzJjPrF731m_p4n9yTgtedx_BX42AzFuRC-eUw==";
        public string GetProductsByBrandID { get { return _GetProductsByBrandID; } }

        private string _GetProductByName = "api/GetProductByName?code=MUznFuQ4_ipv5IH2WEz5_mz_PAGUUVR6DPvh658RW49oAzFuaIrwSw==";
        public string GetProductByName { get { return _GetProductByName; } }

        private string _ArchiveUnarchiveProduct = "api/ArchiveUnarchiveProduct?code=3cMz8x080Ejf4woaBx_-PbTKbU9fh95r-hJHApw6R9buAzFuzqw7FQ==";
        public string ArchiveUnarchiveProduct { get { return _ArchiveUnarchiveProduct; } }

        private string _CreateProductPrice = "api/CreateProductPrice?code=9HTXJa8eDE_8wSGxUzRJXSDkiwugeYKUFxAzW39Ag8rBAzFuwP-6tw==";
        public string CreateProductPrice { get { return _CreateProductPrice; } }

        private string _CreateProductDescription = "api/CreateProductDescription?code=QEPDrgIUy-otkz0H_eTAYVs8qaNqcRBv37f3SjBKVVwrAzFu02d7SQ==";
        public string CreateProductDescription { get { return _CreateProductDescription; } }
       
        private string _UpdateBusinessInfo = "api/UpdateBusinessInfo?code=eKmEHU-Jfzb4C6lq0F7xZk8r-MTBMxB3CanE_6TKkoMrAzFuZUXrVg==";
        public string UpdateBusinessInfo { get { return _UpdateBusinessInfo; } }


        private string _UpdateUserBankInfo = "api/UpdateUserBankInfo?code=TFKwg3-HN6y04MrM4Ff64O6hYXcYgEK_HMgPSQJajLlLAzFuUFgHwg==";
        public string UpdateUserBankInfo { get { return _UpdateUserBankInfo; } }


        private string _GetBrandsData = "api/GetBrandsData?code=vRaZdtGnuomHRXN29Bv7McOhIPVwPq2-O3fwO9XIX8_eAzFuIGOvQA==";
        public string GetBrandsData { get { return _GetBrandsData; } }

        private string _UpdateBrandInfo = "api/UpdateBrandInfo?code=Drq3B91rkKZWkMr__UDSAuLeaeNaDk_x1rrT7tVZymrGAzFuqwYvVg==";
        public string UpdateBrandInfo { get { return _UpdateBrandInfo; } }

        private string _UpdateBrandMediaInfo = "api/UpdateBrandMediaInfo?code=_AG3Pqnmu33qESNJG-NiB2OhQBgO4oX0Wuu35GEdgYhCAzFuIgzdsg==";
        public string UpdateBrandMediaInfo { get { return _UpdateBrandMediaInfo; } }

        private string _UpdateProductInfo = "api/UpdateProductInfo?code=TowjHIv486rjEGHT9vb5wtr13UELvc4iD-WVqrIZOt2YAzFulgsFeA==";
        public string UpdateProductInfo { get { return _UpdateProductInfo; } }

        private string _UpdateProductDescription = "api/UpdateProductDescription?code=KakXn4LxbF6lN4tyayJvwrUbMf2-36LKPvTrgDJti7cxAzFu-Jvr3w==";
        public string UpdateProductDescription { get { return _UpdateProductDescription; } }

        private string _GetProductInfo = "api/GetProductInfo?code=l6Aq-7su8vZJlV2EfFNiu5vCmzVwSXtgZH1CGxKgBaGyAzFuZPxoxQ==";
        public string GetProductInfo { get { return _GetProductInfo; } }

        private string _UpdateReviews = "api/UpdateReviews?code=I2qO_JOYokUbGEG_fb10ySorQH3-eLnDmlZoK_g4DyHLAzFuOUmWTg==";
        public string UpdateReviews { get { return _UpdateReviews; } }

        private string _GetProductsByUserID = "api/GetProductInfoByUser?code=rrZ39rgUfIzyDltzpbzyDZdcvbl_Pnq8Np0HBfljsKZnAzFucLijBQ==";
        public string GetProductsByUserID { get { return _GetProductsByUserID; } }

        private string _CreateFileUpload = "api/CreateFileUpload?code=m9AnNpjM3za-fLrLrBgFqQPI3wD-olMG9bpyqYOcqnZ-AzFuVejDOw==";
        public string CreateFileUpload { get { return _CreateFileUpload; } }

        private string _GetProductData = "api/GetProductData?code=jdJluQs4zJa2USajOoa6_3a8X_hGf2CXs05yXyYUwK7EAzFu_TiKvg==";
        public string GetProductData { get { return _GetProductData; } }

        private string _UpdateProductPrice = "api/UpdatePriceInfo?code=X3mh5r7zGL70RMW8Z0TyLP_E333T-cNChkkCw4QCse0yAzFuVYpeKw==";
        public string UpdateProductPrice { get { return _UpdateProductPrice; } }

        private string _GetBeerTypes = "api/GetBeerTypes?code=fNPfEF3yCywfbewCYTDk_qZx27_ljNGJ9i-KSDNjVhsVAzFu3nFQ1A==";
        public string GetBeerTypes { get { return _GetBeerTypes; } }
    }
    #endregion
}
