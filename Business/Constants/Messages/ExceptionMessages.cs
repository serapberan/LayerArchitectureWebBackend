using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public class ExceptionMessages
    {
        public static readonly string ReturnSuccess = "success";
        public static readonly string DoesntExist = "Üzerinde işlem yapmak istediğiniz kayıt sistemde yok.";
        public static readonly string WrongOldPassword = "Eski şifreniz doğru değil.";
        public static readonly string AlreadyDeleted = "İşlem yapmak istediğiniz kayıt zaten silinmiş.";
        public static readonly string PageAlreadyExists = "Bu dil için zaten bir kayıt var. Mevcut kaydı yönetim panelinden güncelleyebilirsiniz. ";
        public static readonly string ProductModelAlreadyExists = "Bu ürün adında veya bu ürün modelinde bir kayıt sistemde zaten var. Mevcut kaydı ürünler listesinden güncelleyebilirsiniz. ";
        public static readonly string MenuAlreadyExists = "Bu dilde bu sayfa zaten var. Mevcut kaydı yönetim panelinden güncelleyebilirsiniz.";
        public static readonly string CategoryAlreadyExists = "Bu kategori ismiyle aynı isimde bir kayıt sistemde zaten var. Mevcut kaydı ürünler listesinden güncelleyebilirsiniz. ";
        public static readonly string ServerSideValidationFailure = "Sunucu tarafinda form validasyonu basarisiz oldu. Buraya nasil geldiginizi bilmiyorsaniz, tarayicinizda javascripte izin verildiginden emin olun";

    }
}
