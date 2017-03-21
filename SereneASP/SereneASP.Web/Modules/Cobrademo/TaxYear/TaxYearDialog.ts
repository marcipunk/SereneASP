
namespace SereneASP.Cobrademo {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class TaxYearDialog extends Serenity.EntityDialog<TaxYearRow, any> {
        protected getFormKey() { return TaxYearForm.formKey; }
        protected getIdProperty() { return TaxYearRow.idProperty; }
        protected getLocalTextPrefix() { return TaxYearRow.localTextPrefix; }
        protected getNameProperty() { return TaxYearRow.nameProperty; }
        protected getService() { return TaxYearService.baseUrl; }

        protected form = new TaxYearForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}