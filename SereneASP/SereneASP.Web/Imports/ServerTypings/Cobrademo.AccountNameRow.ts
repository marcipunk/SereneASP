namespace SereneASP.Cobrademo {
    export interface AccountNameRow {
        AccountId?: number;
        LanguageId?: string;
        Value?: string;
        Note?: string;
        AccountAvatarId?: number;
        AccountTaxYearId?: number;
        AccountCode?: string;
        LanguageName?: string;
        LanguageIsActive?: boolean;
    }

    export namespace AccountNameRow {
        export const idProperty = 'AccountId';
        export const nameProperty = 'LanguageId';
        export const localTextPrefix = 'Cobrademo.AccountName';

        export namespace Fields {
            export declare const AccountId: string;
            export declare const LanguageId: string;
            export declare const Value: string;
            export declare const Note: string;
            export declare const AccountAvatarId: string;
            export declare const AccountTaxYearId: string;
            export declare const AccountCode: string;
            export declare const LanguageName: string;
            export declare const LanguageIsActive: string;
        }

        ['AccountId', 'LanguageId', 'Value', 'Note', 'AccountAvatarId', 'AccountTaxYearId', 'AccountCode', 'LanguageName', 'LanguageIsActive'].forEach(x => (<any>Fields)[x] = x);
    }
}

