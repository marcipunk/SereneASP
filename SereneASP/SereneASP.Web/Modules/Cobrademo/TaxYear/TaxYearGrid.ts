
namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class TaxYearGrid extends Serenity.EntityGrid<TaxYearRow, any> {
        protected getColumnsKey() { return 'Cobrademo.TaxYear'; }
        protected getDialogType() { return TaxYearDialog; }
        protected getIdProperty() { return TaxYearRow.idProperty; }
        protected getLocalTextPrefix() { return TaxYearRow.localTextPrefix; }
        protected getService() { return TaxYearService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}