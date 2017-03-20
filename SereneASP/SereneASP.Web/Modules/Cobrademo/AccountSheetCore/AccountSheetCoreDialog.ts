
namespace SereneASP.Cobrademo {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class AccountSheetCoreDialog extends Serenity.EntityDialog<AccountSheetCoreRow, any> {
        protected getFormKey() { return AccountSheetCoreForm.formKey; }
        protected getLocalTextPrefix() { return AccountSheetCoreRow.localTextPrefix; }
        protected getNameProperty() { return AccountSheetCoreRow.nameProperty; }
        protected getService() { return AccountSheetCoreService.baseUrl; }

        protected form = new AccountSheetCoreForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}