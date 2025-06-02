flowchart TD
    Start([Service startet])
    DelayTime[Setze delayTime auf GracePeriod-Intervall]
    DebugStart{Logger: Debug aktiviert?}
    LogStart[Logge "Service startet"]
    RegisterStop[Registriere Stop-Callback]
    LoopStart{{Solange nicht gestoppt}}
    DebugWork{Logger: Debug aktiviert?}
    LogWork[Logge "Service macht Arbeit"]
    CheckOrders[CheckConfirmedGracePeriodOrders()]
    Delay[Warte delayTime]
    DebugStop{Logger: Debug aktiviert?}
    LogStop[Logge "Service stoppt"]
    End([Service beendet])

    Start --> DelayTime
    DelayTime --> DebugStart
    DebugStart -- Ja --> LogStart
    LogStart --> RegisterStop
    RegisterStop --> LoopStart
    DebugStart -- Nein --> LoopStart

    LoopStart -- Ja --> DebugWork
    DebugWork -- Ja --> LogWork
    LogWork --> CheckOrders
    DebugWork -- Nein --> CheckOrders
    CheckOrders --> Delay
    Delay --> LoopStart

    LoopStart -- Nein --> DebugStop
    DebugStop -- Ja --> LogStop
    LogStop --> End
    DebugStop -- Nein --> End