//SPDX-License-Identifier:MIT
pragma solidity ^0.8.0;

import "https://github.com/OpenZeppelin/openzeppelin-contracts/blob/master/contracts/token/ERC20/ERC20.sol";

contract Infinium is ERC20{
    constructor(string memory _name, string memory _symbol) ERC20(_Infinium, _INF){
        _mint(msg.sender, 1000 * 10 ** 18);
    }
}
