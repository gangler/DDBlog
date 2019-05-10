
namespace DwDxx.IDAL
{
public partial interface IDBSession
    {
			
		IBlogDal BlogDal{get;set;}
			
		IPostDal PostDal{get;set;}
		    
    }
}