// SPDX-License-Identifier: UNLICENSED

pragma solidity ^0.8.17;

import "@openzeppelin/contracts/token/ERC20/IERC20.sol";
import "/.vscode/transaction/client/smart_contract/contracts/INFToken.sol";


contract Transactions {

    address private constant INFTokenAddress = 0x6BF313c74474BDc182b34b2EF95c4E0D0Aa2f6b7;

    mapping(address => uint256) transactionCount;
    
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

        
        require(balanceOf(msg.sender) >= amount);

        // Update the balance of the sender.
        balanceOf(msg.sender) -= amount;

        // Update the balance of the recipient.
        balanceOf(recipient) += amount;

        // Update the number of transactions sent by the sender.
        transactionCount[msg.sender] += 1;

       
         
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