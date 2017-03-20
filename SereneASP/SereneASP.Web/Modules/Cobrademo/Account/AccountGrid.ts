
namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class AccountGrid extends Serenity.EntityGrid<AccountRow, any> {
        protected getColumnsKey() { return 'Cobrademo.Account'; }
        protected getDialogType() { return AccountDialog; }
        protected getIdProperty() { return AccountRow.idProperty; }
        protected getLocalTextPrefix() { return AccountRow.localTextPrefix; }
        protected getService() { return AccountService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}