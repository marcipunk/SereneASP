
namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class AccountSheetCoreGrid extends Serenity.EntityGrid<AccountSheetCoreRow, any> {
        protected getColumnsKey() { return 'Cobrademo.AccountSheetCore'; }
        protected getDialogType() { return AccountSheetCoreDialog; }
        protected getLocalTextPrefix() { return AccountSheetCoreRow.localTextPrefix; }
        protected getService() { return AccountSheetCoreService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}