
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountSheetCoreEditorDialog extends Common.GridEditorDialog<AccountSheetCoreRow> {
        protected getFormKey() { return AccountSheetCoreForm.formKey; }        protected getLocalTextPrefix() { return AccountSheetCoreRow.localTextPrefix; }
        protected getNameProperty() { return AccountSheetCoreRow.nameProperty; }
        protected form = new AccountSheetCoreForm(this.idPrefix);
    }
}