using System;
using System.Collections.Generic;
using System.Linq;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class SheetRepo: ISheetRepo
    {
        private static List<Sheet> Sheets { get; set; } = new List<Sheet>()
        {
            new Sheet
            {
                Id = Guid.Parse("95DDE5A0-810C-A196-C069-F055397768EC"),
                Date = DateTime.Parse("2021-10-08T09:10:27-07:00"),
                EmployeeId = Guid.Parse("2995949A-4697-FA74-8A8F-DCE13DEA666E"),
                ContractId = Guid.Parse("47B412D3-7233-8942-017A-91510EEFE2FF"),
                ServiceId = Guid.Parse("77330C8D-103E-D8B5-E605-3C195DDB0B7F"), Amount = 6
            },
            new Sheet
            {
                Id = Guid.Parse("4AFFEFD4-7228-A3D4-E637-44AC5AA82627"),
                Date = DateTime.Parse("2020-10-14T19:33:14-07:00"),
                EmployeeId = Guid.Parse("37AC1389-2A82-5085-F97B-7279AAA23D7F"),
                ContractId = Guid.Parse("35290D4D-48D5-3BD0-44C8-EEBE58A4ABF4"),
                ServiceId = Guid.Parse("1267447E-8E04-DC44-10DC-8810F7D07386"), Amount = 2
            },
            new Sheet
            {
                Id = Guid.Parse("754F3C6B-A248-96F5-6BE8-3F38C89BBE82"),
                Date = DateTime.Parse("2021-02-21T01:25:31-08:00"),
                EmployeeId = Guid.Parse("6ECEAF31-FF6D-E97D-F735-CDD43CF257F8"),
                ContractId = Guid.Parse("F211D8F6-361D-CC21-4957-CC5ADB1D8CF7"),
                ServiceId = Guid.Parse("97EE9B5D-6B00-A5C0-7458-52271A441635"), Amount = 2
            },
            new Sheet
            {
                Id = Guid.Parse("0530D7C7-B606-0379-6B04-9415DC50B18B"),
                Date = DateTime.Parse("2020-08-15T03:50:53-07:00"),
                EmployeeId = Guid.Parse("461E1C79-767D-813F-DA75-3E7233150199"),
                ContractId = Guid.Parse("FD986D9E-BD8C-DC9C-5A9A-32A9E42F97A6"),
                ServiceId = Guid.Parse("1834CC2D-9F34-7FEC-19F1-9E2DCB037372"), Amount = 7
            },
            new Sheet
            {
                Id = Guid.Parse("C4EEEFA4-4DF5-5973-AC55-77EE2AFECF79"),
                Date = DateTime.Parse("2021-12-13T13:32:45-08:00"),
                EmployeeId = Guid.Parse("7E66549B-3D99-6F4B-9DF3-510589BA6EAA"),
                ContractId = Guid.Parse("16FB30A7-82FF-C155-9760-38B1129AC957"),
                ServiceId = Guid.Parse("25692E86-1B2C-BE65-E6E2-4A173782BE19"), Amount = 4
            },
            new Sheet
            {
                Id = Guid.Parse("B53EA1BF-2E60-E553-5275-20603D7B0A7C"),
                Date = DateTime.Parse("2021-04-29T15:52:02-07:00"),
                EmployeeId = Guid.Parse("82442770-06B9-4F1F-978E-F3891B276AC8"),
                ContractId = Guid.Parse("22269DA6-E1FC-77C2-3A79-25EA1BA996C2"),
                ServiceId = Guid.Parse("38603C58-F122-CBBB-8174-A0E90EDA1422"), Amount = 1
            },
            new Sheet
            {
                Id = Guid.Parse("DC9ABF2F-62CF-1602-0C15-527BBD87EF93"),
                Date = DateTime.Parse("2021-08-18T08:51:58-07:00"),
                EmployeeId = Guid.Parse("A66BCA76-E3AE-66C0-B6E4-C6A84A337E42"),
                ContractId = Guid.Parse("214FFD01-7C40-A6B6-A17C-F0772433A913"),
                ServiceId = Guid.Parse("A7865C87-1A1C-85AE-CE9F-53BBE34ABA71"), Amount = 8
            },
            new Sheet
            {
                Id = Guid.Parse("011FD281-AD0D-78C5-EFED-72E4CC4BC117"),
                Date = DateTime.Parse("2021-09-09T18:31:41-07:00"),
                EmployeeId = Guid.Parse("D01C688C-A46C-3B39-639C-5362306C5312"),
                ContractId = Guid.Parse("31733068-3E25-4E1E-37B4-9F77E81A2037"),
                ServiceId = Guid.Parse("7082B532-2B89-F658-68A8-E1D4DB18F56B"), Amount = 7
            },
            new Sheet
            {
                Id = Guid.Parse("6EC4482C-417A-F16E-4113-09CCAE143D4A"),
                Date = DateTime.Parse("2021-04-22T07:09:19-07:00"),
                EmployeeId = Guid.Parse("F97D982C-7919-F151-186A-77B7785E1D96"),
                ContractId = Guid.Parse("D9D64418-DEBC-6781-95BC-A100114E3B22"),
                ServiceId = Guid.Parse("D5DB5E2A-0EE1-A97D-35FC-07E80F7A0C1C"), Amount = 4
            },
        };

        public Sheet GetItem(Guid id)
        {
            return Sheets.FirstOrDefault(x => x.Id == id);
        }

        public IEquatable<Sheet> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Add(Sheet item)
        {
            Sheets.Add(item);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}