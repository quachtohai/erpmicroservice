namespace BuildingBlocks.Pagination;
public record PaginationRequest(int PageIndex = 1, int PageSize = 10);
public record PaginationRequestWithDate( int PageIndex = 1, int PageSize = 10, DateTime? FromDate =null, 
    DateTime? ToDate = null,string Equal ="", string Filter = "", string Q ="", string Fields = ""  );

