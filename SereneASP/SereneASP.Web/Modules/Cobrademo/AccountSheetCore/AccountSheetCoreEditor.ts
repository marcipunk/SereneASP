
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class AccountSheetCoreEditor extends Common.GridEditorBase<AccountSheetCoreRow> {
        protected getColumnsKey() { return 'Cobrademo.AccountSheetCore'; }
        protected getDialogType() { return AccountSheetCoreEditorDialog; }        protected getLocalTextPrefix() { return AccountSheetCoreRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}