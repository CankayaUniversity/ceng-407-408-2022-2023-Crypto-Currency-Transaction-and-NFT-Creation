using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Utils;
using static System.Reflection.Metadata.BlobBuilder;

namespace Models
{

    public class Block
    {
        public int Height { get; set; }
        public long TimeStamp { get; set; }
        public byte[] PrevHash { get; set; }
        public byte[] Hash { get; set; }
        public Transaction[] Transactions { get; set; }
        public string Creator { get; set; }

        public Block(int height, byte[] prevHash, List<Transaction> transactions, string creator)
        {
            Height = height;
            PrevHash = prevHash;
            TimeStamp = DateTime.Now.Ticks;
            Transactions = transactions.ToArray();
            Hash = GenerateHash();
            Creator = creator;
        }

        // generate hash of current block
        public byte[] GenerateHash()
        {
            var sha = SHA256.Create();
            byte[] timeStamp = BitConverter.GetBytes(TimeStamp);

            var transactionHash = Transactions.ConvertToByte();

            byte[] headerBytes = new byte[timeStamp.Length + PrevHash.Length + transactionHash.Length];

            Buffer.BlockCopy(timeStamp, 0, headerBytes, 0, timeStamp.Length);
            Buffer.BlockCopy(PrevHash, 0, headerBytes, timeStamp.Length, PrevHash.Length);
            Buffer.BlockCopy(transactionHash, 0, headerBytes, timeStamp.Length + PrevHash.Length, transactionHash.Length);

            byte[] hash = sha.ComputeHash(headerBytes);

            return hash;

        }


    }

    public void AddBlock(Transaction[] transactions)
    {
        var lastBlock = GetLastBlock();
        var nextHeight = lastBlock.Height + 1;
        var prevHash = lastBlock.Hash;
        var timestamp = DateTime.Now.Ticks;
        var block = new Block(nextHeight, prevHash, transactions, "Admin");
        Blocks.Add(block);
    }

    private Block CreateGenesisBlock()
    {
        var lst = new List<Transaction>();
        var trx = new Transaction
        {
            Amount = 1000,
            Sender = "System",
            Recipient = "Genesis Account",
            Fee = 0.0001
        };
        lst.Add(trx);

        var trxByte = lst.ToArray().ConvertToByte();
        return new Block(1, String.Empty.ConvertToBytes(), lst.ToArray(), "Admin");
    }

    public void PrintGenesisBlock()
    {
        Console.WriteLine("\n\n==== Genesis Block ====");
        var block = Blocks[0];
        PrintBlock(block);
    }

    public void PrintLastBlock()
    {
        Console.WriteLine("\n\n==== Last Block ====");
        var lastBlock = GetLastBlock();
        PrintBlock(lastBlock);
    }

    /**
* Print balance by name
**/
    public void PrintBalance(string name)
    {
        Console.WriteLine("\n\n==== Balance for {0} ====", name);
        double balance = 0;
        double spending = 0;
        double income = 0;
        foreach (Block block in Blocks)
        {
            var transactions = block.Transactions;
            foreach (var transaction in transactions)
            {
                var sender = transaction.Sender;
                var recipient = transaction.Recipient;
                if (name.ToLower().Equals(sender.ToLower()))
                {
                    spending += transaction.Amount + transaction.Fee;
                }
                if (name.ToLower().Equals(recipient.ToLower()))
                {
                    income += transaction.Amount;
                }
                balance = income - spending;
            }
        }
        Console.WriteLine("Balance :{0}", balance);
        Console.WriteLine("---------");
    }

    /**
         * Print all block in blockchain
         */

    public void PrintBlocks()
    {

        Console.WriteLine("\n\n====== Blockchain Explorer =====");

        foreach (Block block in Blocks)
        {
            PrintBlock(block);
        }

    }

    private void PrintBlock(Block block)
    {
        Console.WriteLine("Height      :{0}", block.Height);
        Console.WriteLine("Timestamp   :{0}", block.TimeStamp.ConvertToDateTime());
        Console.WriteLine("Prev. Hash  :{0}", block.PrevHash.ConvertToHexString());
        Console.WriteLine("Hash        :{0}", block.Hash.ConvertToHexString());
        Console.WriteLine("Transactins :{0}", block.Transactions.ConvertToString());
        Console.WriteLine("Creator     :{0}", block.Creator);
        Console.WriteLine("--------------");
    }
}