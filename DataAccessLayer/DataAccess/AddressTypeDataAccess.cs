using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace DataAccessLayer.DataAccess
{

   public class AddressTypeDataAccess
    {
        HotelManagement_Context _Context = new HotelManagement_Context();

        public List<AddressTypeModel> GetAllAddressType()
        {
            List<tblAddressType> addressTypeList = _Context.tblAddressTypes.ToList();
            List<AddressTypeModel> addressTypeListBo = new List<AddressTypeModel>();

            foreach (tblAddressType addressType in addressTypeList)
            {
                AddressTypeModel addressTypeModel = new AddressTypeModel
                {
                    Id = addressType.Id,
                    Name = addressType.Name,
                    CREATEDBY = addressType.CREATEDBY,
                    CREATEDDATE = addressType.CREATEDDATE,
                    MODIFIEDBY = addressType.MODIFIEDBY,
                    MODIFIEDDATE = addressType.MODIFIEDDATE,
                    ISACTIVE = addressType.ISACTIVE

                };
                addressTypeListBo.Add(addressTypeModel);
            }

            return addressTypeListBo;
        }



    }
}
