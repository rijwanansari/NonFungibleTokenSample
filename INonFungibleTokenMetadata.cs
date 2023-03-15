using Stratis.SmartContracts;

namespace NFTContract
{
    public interface INonFungibleTokenMetadata
    {
        string Name { get; }
        string Symbol { get; }

        string TokenURI(UInt256 tokenId);

    }
}
