# MOTB
Message on the block.
A simple smart contract that allow you to write your message permanently in blockchail.
It is created for testing The White Rabbit Browser

It uses a simple concept of Storage and composite keys.
Functions:
* getheight - to get current number of messages on the blockchain
* write - write a message to blockchain
* getmessage - retrieve message from the blockchain at specific index


# Deployment
To deploy this smart contract you need to:
1. Clone the repository
2. Open the solution in Visual Studio
3. Restore the nuget package
4. Deploy the AVM using Neo-GUI


# Testing & Web App
The smart contract has been deployed on TestNet provided by The Positive Lab, [read more here](https://github.com/ThePositiveLab/NeoPrivateTestNet)

Script Hash: 0xec06bc2993745cdc1d9462254a11b45de1a40021

Web UI: [White Rabbit Browser](http://tpl-whiterabbit.azurewebsites.net/Home/Test)
