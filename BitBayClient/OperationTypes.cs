using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public enum OperationTypes
    {
        CREATE_BALANCE,
        ADD_FUNDS,
        SUBTRACT_FUNDS,
        TRANSFER_FROM,
        TRANSFER_TO,
        TRANSACTION_COMMISSION_OUTCOME,
        TRANSACTION_PRE_LOCKING,
        LOCK_FUNDS,
        ADMIN_LOCK_FUNDS,
        UNLOCK_FUNDS,
        ADMIN_UNLOCK_FUNDS,
        TRANSACTION_POST_INCOME,
        TRANSACTION_POST_OUTCOME,
        ADMIN_ADD_FUNDS,
        ADMIN_SUBTRACT_FUNDS,
        TRANSACTION_OFFER_ABORTED_RETURN,
        AFFILIATE_FUNDS_TRANSFER,
        PAY_WITHDRAW_LOCK,
        TRANSACTION_OFFER_COMPLETED_RETURN,
        TRANSACTION_FAIL_UNLOCKING,
        WITHDRAWAL_LOCK_FUNDS,
        WITHDRAWAL_UNLOCK_FUNDS,
        WITHDRAWAL_SUBTRACT_FUNDS,
        FUNDS_MIGRATION,
        TRANSACTION_COMMISSION_RETURN,
        ADD_FUNDS_ERROR_REFUND,
        OLD_ADDRESS_CRYPTO_DEPOSIT,
        FIAT_DEPOSIT_MIGRATED,
        ADMIN_WITHDRAWAL_REFUND,
        SUBTRACT_FUNDS_ERROR_CORRECTION,
        ADD_FUNDS_COMPENSATION,
        BITCOIN_GOLD_FORK,
        BALANCE_DEPOSIT_CORRECTION,
        WITHDRAWAL_CUSTOM_COMMISSION
    }

    public static class OperationTypesExtension
    {
        public static OperationTypes Parse(string name)
        {
            return (OperationTypes)Enum.Parse(typeof(OperationTypes), name);
        }

        public static bool TryParse(string name, ref OperationTypes message)
        {
            try
            {
                message = (OperationTypes)Enum.Parse(typeof(OperationTypes), name);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
