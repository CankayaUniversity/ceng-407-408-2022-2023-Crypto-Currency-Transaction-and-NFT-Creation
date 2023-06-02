

require('@nomiclabs/hardhat-waffle');


module.exports = {
  solidity: "0.8.18",
  networks: {
    sepolia: {
      url: 'https://eth-sepolia.g.alchemy.com/v2/vhQYivDQBogLG_URIcUytyQgfKu_cjPR',
      accounts: ['bf7cd6c1187b7cb1ab0cf34ccb28784528f96e7c5c4337bef53af199e8f3a984'],
    },
  },
};
