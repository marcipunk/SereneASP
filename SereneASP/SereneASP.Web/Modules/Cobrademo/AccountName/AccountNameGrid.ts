
namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class AccountNameGrid extends Serenity.EntityGrid<AccountNameRow, any> {
        protected getColumnsKey() { return 'Cobrademo.AccountName'; }
        protected getDialogType() { return AccountNameDialog; }
        protected getIdProperty() { return AccountNameRow.idProperty; }
        protected getLocalTextPrefix() { return AccountNameRow.localTextPrefix; }
        protected getService() { return AccountNameService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}