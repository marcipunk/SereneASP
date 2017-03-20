
namespace SereneASP.Cobrademo.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.AccountSheetCoreRepository;
    using MyRow = Entities.AccountSheetCoreRow;

    [RoutePrefix("Services/Cobrademo/AccountSheetCore"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class AccountSheetCoreController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
      

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
