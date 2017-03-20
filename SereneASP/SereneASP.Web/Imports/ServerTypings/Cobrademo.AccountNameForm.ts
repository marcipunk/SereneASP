

namespace SereneASP.Cobrademo {
    export class AccountNameForm extends Serenity.PrefixedContext {
        static formKey = 'Cobrademo.AccountName';
    }

    export interface AccountNameForm {
        LanguageId: Serenity.StringEditor;
        Value: Serenity.StringEditor;
        Note: Serenity.StringEditor;
    }

    [['LanguageId', () => Serenity.StringEditor], ['Value', () => Serenity.StringEditor], ['Note', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(AccountNameForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}