
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class TaxYearEditor extends Common.GridEditorBase<TaxYearRow> {
        protected getColumnsKey() { return 'Cobrademo.TaxYear'; }
        protected getDialogType() { return TaxYearEditorDialog; }
                protected getLocalTextPrefix() { return TaxYearRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}