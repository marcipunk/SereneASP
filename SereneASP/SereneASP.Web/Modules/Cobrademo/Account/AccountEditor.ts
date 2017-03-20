
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class AccountEditor extends Common.GridEditorBase<AccountRow> {
        protected getColumnsKey() { return 'Cobrademo.Account'; }
        protected getDialogType() { return AccountEditorDialog; }
                protected getLocalTextPrefix() { return AccountRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}