﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi); //method //proses input data


        [OperationContract]
        string editPemesanan(string IDPemesanan, string NamaCustomer, string No_telpon);

        [OperationContract]
        string deletePemesanan(string IDPemesanan);

        [OperationContract]
        List<CekLokasi> ReviewLokasi(); //menampilkan data yang ada di database (select all) // menampilkan isi dari yang ada contact

        [OperationContract]
        List<DetailLokasi> DetailLokasi(); //menampilkan detail lokasi

        [OperationContract]
        List<Pemesanan> Pemesanan();

        [OperationContract]
        string Login(string username, string password);

        [OperationContract]
        string Register(string username, string password, string kategori);

        [OperationContract]
        string UpdateRegister(string username, string password, string kategori, int id);

        [OperationContract]
        string DeleteRegister(string username);

        [OperationContract]
        List<DataRegister> DataRegist();


        // TODO: Add your service operations here
    }


    [DataContract]
    public class CekLokasi // daftar lokasi nongrong
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class

        [DataMember]
        public string NamaLokasi { get; set; }

        [DataMember]
        public string DeskripsiSingkat { get; set; }
    }

    [DataContract]
    public class DetailLokasi // daftar lokasi nongrong
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class

        [DataMember]
        public string NamaLokasi { get; set; }

        [DataMember]
        public string DeskripsiFull { get; set; }

        [DataMember]
        public int Kuota { get; set; }

    }

    [DataContract]
    public class Pemesanan // create
    {
        [DataMember]
        public string IDPemesanan { get; set; } //variabel dari public class

        [DataMember]
        public string NamaCustomer { get; set; }

        [DataMember]
        public string NoTelepon { get; set; }

        [DataMember]
        public int JumlahPemesanan { get; set; }

        [DataMember]
        public string Lokasi { get; set; }

    }

    [DataContract]
    public class DataRegister
    {
        [DataMember(Order = 1)]
        public int id { get; set; }

        [DataMember(Order = 2)]
        public string username { get; set; }

        [DataMember(Order = 3)]
        public string password { get; set; }

        [DataMember(Order = 4)]
        public string kategori { get; set; }
    }
}