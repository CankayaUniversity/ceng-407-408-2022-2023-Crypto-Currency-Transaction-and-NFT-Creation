const Infinium = artifacts.require("./infiniumICO/Infinium");
const InfiniumTokenSale = artifacts.require("./infiniumICO/InfiniumTokenSale");

module.exports = function (deployer) {
  deployer.deploy(Infinium).then(() => {
    deployer.deploy(InfiniumTokenSale, Infinium.address);
  });
  // If this code doesn't work, to deploy the contract token sale
  // we have to copy the contract tokenn address and paste here
  deployer.deploy(InfiniumTokenSale, "0x6E788679F6a5bF57aB90EcB2B6c0a2fBd4A0864e");
};