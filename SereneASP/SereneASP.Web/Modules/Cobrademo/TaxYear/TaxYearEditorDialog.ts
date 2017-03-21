
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TaxYearEditorDialog extends Common.GridEditorDialog<TaxYearRow> {
        protected getFormKey() { return TaxYearForm.formKey; }
                protected getLocalTextPrefix() { return TaxYearRow.localTextPrefix; }
        protected getNameProperty() { return TaxYearRow.nameProperty; }
        protected form = new TaxYearForm(this.idPrefix);
    }
}