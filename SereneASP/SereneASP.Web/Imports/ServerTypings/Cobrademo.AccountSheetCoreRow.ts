
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
            export declare const TaxYearId;
            export declare const LayerId;
            export declare const AccountId;
            export declare const BookingDate;
            export declare const CompletionDate;
            export declare const TabletypeId;
            export declare const FileId;
            export declare const FileAvatarId;
            export declare const FileGeneratedSign;
            export declare const FileUserSign;
            export declare const OrdinalNumber;
            export declare const SrcAvatarId;
            export declare const LedgerItemId;
            export declare const ItemTypeId;
            export declare const SrcFinanceLinkId;
            export declare const EventTypeId;
            export declare const PartnerId;
            export declare const ReferenceNumber;
            export declare const VoucherNum;
            export declare const LedgerCurrencyId;
            export declare const LedgerRate;
            export declare const LedgerName;
            export declare const LedgerItemCurrencyId;
            export declare const LedgerItemRate;
            export declare const LedgerItemName;
            export declare const Side;
            export declare const OriginalAmount;
            export declare const Amount;
            export declare const OriginalDebitAmount;
            export declare const OriginalCreditAmount;
            export declare const DebitAmount;
            export declare const CreditAmount;
            export declare const AccountCode;
            export declare const ContraAccounts;
            export declare const IsFinalized;
            export declare const IsActive;
            export declare const AccountInTaxYear;
            export declare const AccountInLayer;
            export declare const BookingDateInTaxYear;
            export declare const IsCurrent;
        }

        ['TaxYearId', 'LayerId', 'AccountId', 'BookingDate', 'CompletionDate', 'TabletypeId', 'FileId', 'FileAvatarId', 'FileGeneratedSign', 'FileUserSign', 'OrdinalNumber', 'SrcAvatarId', 'LedgerItemId', 'ItemTypeId', 'SrcFinanceLinkId', 'EventTypeId', 'PartnerId', 'ReferenceNumber', 'VoucherNum', 'LedgerCurrencyId', 'LedgerRate', 'LedgerName', 'LedgerItemCurrencyId', 'LedgerItemRate', 'LedgerItemName', 'Side', 'OriginalAmount', 'Amount', 'OriginalDebitAmount', 'OriginalCreditAmount', 'DebitAmount', 'CreditAmount', 'AccountCode', 'ContraAccounts', 'IsFinalized', 'IsActive', 'AccountInTaxYear', 'AccountInLayer', 'BookingDateInTaxYear', 'IsCurrent'].forEach(x => (<any>Fields)[x] = x);
    }
}

