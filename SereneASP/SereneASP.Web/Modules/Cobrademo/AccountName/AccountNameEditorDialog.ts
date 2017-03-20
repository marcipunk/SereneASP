
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountNameEditorDialog extends Common.GridEditorDialog<AccountNameRow> {
        protected getFormKey() { return AccountNameForm.formKey; }
                protected getLocalTextPrefix() { return AccountNameRow.localTextPrefix; }
        protected getNameProperty() { return AccountNameRow.nameProperty; }
        protected form = new AccountNameForm(this.idPrefix);
    }
}