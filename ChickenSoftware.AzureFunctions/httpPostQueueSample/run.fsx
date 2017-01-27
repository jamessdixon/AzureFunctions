open System

let Run(personItem: string, 
        expirationTime: DateTimeOffset, 
        insertionTime: DateTimeOffset , 
        nextVisibleTime: DateTimeOffset ,
        queueTrigger: string ,
        id: string ,
        popReceipt: string ,
        dequeueCount: int,
        log: TraceWriter) = log.Info("Hello")