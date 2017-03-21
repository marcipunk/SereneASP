namespace SereneASP.Cobrademo {
    export interface AccountSheetCoreRow {
        TaxYearId?: number;
        LayerId?: number;
        AccountId?: number;
        BookingDate?: string;
        CompletionDate?: string;
        TabletypeId?: number;
        FileId?: number;
        FileAvatarId?: number;
        FileGeneratedSign?: string;
        FileUserSign?: string;
        OrdinalNumber?: number;
        SrcAvatarId?: number;
        LedgerItemId?: number;
        ItemTypeId?: number;
        SrcFinanceLinkId?: number;
        EventTypeId?: number;
        PartnerId?: number;
        ReferenceNumber?: number;
        VoucherNum?: string;
        LedgerCurrencyId?: string;
        LedgerRate?: number;
        LedgerName?: string;
        LedgerItemCurrencyId?: string;
        LedgerItemRate?: number;
        LedgerItemName?: string;
        Side?: number;
        OriginalAmount?: number;
        Amount?: number;
        OriginalDebitAmount?: number;
        OriginalCreditAmount?: number;
        DebitAmount?: number;
        CreditAmount?: number;
        AccountCode?: string;
        ContraAccounts?: string;
        IsFinalized?: boolean;
        IsActive?: boolean;
        AccountInTaxYear?: boolean;
        AccountInLayer?: boolean;
        BookingDateInTaxYear?: boolean;
        IsCurrent?: boolean;
    }

    export namespace AccountSheetCoreRow {
        export const nameProperty = 'FileGeneratedSign';
        export const localTextPrefix = 'Cobrademo.AccountSheetCore';

        export namespace Fields {
            export declare const TaxYearId: string;
            export declare const LayerId: string;
            export declare const AccountId: string;
            export declare const BookingDate: string;
            export declare const CompletionDate: string;
            export declare const TabletypeId: string;
            export declare const FileId: string;
            export declare const FileAvatarId: string;
            export declare const FileGeneratedSign: string;
            export declare const FileUserSign: string;
            export declare const OrdinalNumber: string;
            export declare const SrcAvatarId: string;
            export declare const LedgerItemId: string;
            export declare const ItemTypeId: string;
            export declare const SrcFinanceLinkId: string;
            export declare const EventTypeId: string;
            export declare const PartnerId: string;
            export declare const ReferenceNumber: string;
            export declare const VoucherNum: string;
            export declare const LedgerCurrencyId: string;
            export declare const LedgerRate: string;
            export declare const LedgerName: string;
            export declare const LedgerItemCurrencyId: string;
            export declare const LedgerItemRate: string;
            export declare const LedgerItemName: string;
            export declare const Side: string;
            export declare const OriginalAmount: string;
            export declare const Amount: string;
            export declare const OriginalDebitAmount: string;
            export declare const OriginalCreditAmount: string;
            export declare const DebitAmount: string;
            export declare const CreditAmount: string;
            export declare const AccountCode: string;
            export declare const ContraAccounts: string;
            export declare const IsFinalized: string;
            export declare const IsActive: string;
            export declare const AccountInTaxYear: string;
            export declare const AccountInLayer: string;
            export declare const BookingDateInTaxYear: string;
            export declare const IsCurrent: string;
        }

        ['TaxYearId', 'LayerId', 'AccountId', 'BookingDate', 'CompletionDate', 'TabletypeId', 'FileId', 'FileAvatarId', 'FileGeneratedSign', 'FileUserSign', 'OrdinalNumber', 'SrcAvatarId', 'LedgerItemId', 'ItemTypeId', 'SrcFinanceLinkId', 'EventTypeId', 'PartnerId', 'ReferenceNumber', 'VoucherNum', 'LedgerCurrencyId', 'LedgerRate', 'LedgerName', 'LedgerItemCurrencyId', 'LedgerItemRate', 'LedgerItemName', 'Side', 'OriginalAmount', 'Amount', 'OriginalDebitAmount', 'OriginalCreditAmount', 'DebitAmount', 'CreditAmount', 'AccountCode', 'ContraAccounts', 'IsFinalized', 'IsActive', 'AccountInTaxYear', 'AccountInLayer', 'BookingDateInTaxYear', 'IsCurrent'].forEach(x => (<any>Fields)[x] = x);
    }
}

