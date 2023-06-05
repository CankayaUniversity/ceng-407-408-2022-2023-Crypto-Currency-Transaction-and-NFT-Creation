// SPDX-License-Identifier: UNLICENSED

pragma solidity ^0.8.17;

import "@openzeppelin/contracts/token/ERC20/IERC20.sol";
import {infTokenAddress} from "./client/src/utils/constants";
import "/.vscode/transaction/client/smart_contract/contracts/INFToken.sol";

contract Transactions {

    // The INF token contract.
    INFToken public INFTokenContract;
    
    mapping(address => uint256) transactionCount;
    
    constructor(address infTokenAddress){
        INFTokenContract = INFToken(infTokenAddress);
    }
    event Transfer(address from, address receiver, uint amount, string message, uint256 timestamp, string keyword);
  
    struct TransferStruct {
        address sender;
        address receiver;
        uint amount;
        string message;
        uint256 timestamp;
        string keyword;
    }

    TransferStruct[] transactions;

    function sendTransaction(address receiver, uint256 amount ,string memory message, string memory keyword) public returns (bool){

        require(amount<=balances[msg.sender],"Insufficient balance");
        require(amount > 0);
        require(reciver != address(0));

        // Check if the sender has enough INF tokens to send.
        require(INFTokenContract.balanceOf(msg.sender) >= amount);

        // Update the balance of the sender.
        INFTokenContract.balanceOf(msg.sender) -= amount;

        // Update the balance of the recipient.
        INFTokenContract.balanceOf(recipient) += amount;

        // Update the number of transactions sent by the sender.
        transactionCount[msg.sender] += 1;

        // Emit a sendTransaction event.
        //emit SendTransaction(msg.sender, recipient, amount);

        emit Transfer(msg.sender,receiver,amount, message, block.timestamp, keyword);
        return true;
    }

    function balanceOf(address account) public override returns(uint256){
        return balances[account];
    }
    
    function addToBlockchain(address payable receiver, uint amount, string memory message, string memory keyword) public {
        transactionCount += 1;
        transactions.push(TransferStruct(msg.sender, receiver, amount, message, block.timestamp, keyword));
        emit Transfer(msg.sender, receiver, amount, message, block.timestamp, keyword);
    }

    function getAllTransactions() public view returns (TransferStruct[] memory) {
        return transactions;
    }

    function getTransactionCount() public view returns (uint256) {
        return transactionCount;
    }

    

    

    
}