
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace SereneASP.Cobrademo {
    
    @Serenity.Decorators.registerClass()
    export class AccountNameEditor extends Common.GridEditorBase<AccountNameRow> {
        protected getColumnsKey() { return 'Cobrademo.AccountName'; }
        protected getDialogType() { return AccountNameEditorDialog; }
                protected getLocalTextPrefix() { return AccountNameRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}