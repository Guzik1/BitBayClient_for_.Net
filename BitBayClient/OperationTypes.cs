namespace BitBayClient
{
    /// <summary>
    /// Types of operation enum.
    /// </summary>
    public enum OperationTypes
    {
        /// <summary>Create balance.</summary>
        CREATE_BALANCE,
        /// <summary>Add funds to balance.</summary>
        ADD_FUNDS,
        /// <summary>Withdraw funds from balance.</summary>
        SUBTRACT_FUNDS,
        /// <summary>Transfer from balance.</summary>
        TRANSFER_FROM,
        /// <summary>Transfer to balance.</summary>
        TRANSFER_TO,
        /// <summary>Pay transaction commision.</summary>
        TRANSACTION_COMMISSION_OUTCOME,
        /// <summary>Locked funds on balance.</summary>
        TRANSACTION_PRE_LOCKING,
        /// <summary>Locked funds on balance.</summary>
        LOCK_FUNDS,
        /// <summary>Administrator was locked funds on balance.</summary>
        ADMIN_LOCK_FUNDS,
        /// <summary>Unlock funds on balance.</summary>
        UNLOCK_FUNDS,
        /// <summary>Administrator was unlock funds on balance.</summary>
        ADMIN_UNLOCK_FUNDS,
        /// <summary>Get funds from transaction to balance.</summary>
        TRANSACTION_POST_INCOME,
        /// <summary>Pay funds from transaction from balance.</summary>
        TRANSACTION_POST_OUTCOME,
        /// <summary>Administrator correct (add) funds on balance.</summary>
        ADMIN_ADD_FUNDS,
        /// <summary>Administrator correct (substract) funds on balance.</summary>
        ADMIN_SUBTRACT_FUNDS,
        /// <summary>Return funds for delete offer to balance.</summary>
        TRANSACTION_OFFER_ABORTED_RETURN,
        /// <summary>Affilate funds from partner program.</summary>
        AFFILIATE_FUNDS_TRANSFER,
        /// <summary>Locked funds on balance.</summary>
        PAY_WITHDRAW_LOCK,
        /// <summary>Cancellation of offer bellow minimum value.</summary>
        TRANSACTION_OFFER_COMPLETED_RETURN,
        /// <summary>Return funds after unsuccessful add offer.</summary>
        TRANSACTION_FAIL_UNLOCKING,
        /// <summary>Lock funds.</summary>
        WITHDRAWAL_LOCK_FUNDS,
        /// <summary>Unlock funds.</summary>
        WITHDRAWAL_UNLOCK_FUNDS,
        /// <summary>Withdraw funds.</summary>
        WITHDRAWAL_SUBTRACT_FUNDS,
        /// <summary>Migration funds.</summary>
        FUNDS_MIGRATION,
        /// <summary>Return transaction commision to balance.</summary>
        TRANSACTION_COMMISSION_RETURN,
        /// <summary>Lock correction.</summary>
        ADD_FUNDS_ERROR_REFUND,
        /// <summary>Deposit on constant addres.</summary>
        OLD_ADDRESS_CRYPTO_DEPOSIT,
        /// <summary>Real currency deposit on balance.</summary>
        FIAT_DEPOSIT_MIGRATED,
        /// <summary>Return funds for canceked withdraw by administrator.</summary>
        ADMIN_WITHDRAWAL_REFUND,
        /// <summary>Funds correction.</summary>
        SUBTRACT_FUNDS_ERROR_CORRECTION,
        /// <summary>Recompense.</summary>
        ADD_FUNDS_COMPENSATION,
        /// <summary>Bitcoin gold fork.</summary>
        BITCOIN_GOLD_FORK,
        /// <summary>Deposit correction.</summary>
        BALANCE_DEPOSIT_CORRECTION,
        /// <summary>Commission for Bitcoin network..</summary>
        WITHDRAWAL_CUSTOM_COMMISSION
    }
}
