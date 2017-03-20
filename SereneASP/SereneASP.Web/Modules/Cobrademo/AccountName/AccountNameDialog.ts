
namespace SereneASP.Cobrademo {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class AccountNameDialog extends Serenity.EntityDialog<AccountNameRow, any> {
        protected getFormKey() { return AccountNameForm.formKey; }
        protected getIdProperty() { return AccountNameRow.idProperty; }
        protected getLocalTextPrefix() { return AccountNameRow.localTextPrefix; }
        protected getNameProperty() { return AccountNameRow.nameProperty; }
        protected getService() { return AccountNameService.baseUrl; }

        protected form = new AccountNameForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}