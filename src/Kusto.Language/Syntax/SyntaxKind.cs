﻿namespace Kusto.Language.Syntax
{
    /// <summary>
    /// All the kinds of tokens that appear in Kusto 
    /// </summary>
    /// <remarks>
    /// Note for implementors: Are you adding a new value to this enum?
    /// Be sure to also add a new entry referencing it to the
    /// <see cref="SyntaxFacts"/> table.
    /// </remarks>
    public enum SyntaxKind : short
    {
        None = 0,

        // keywords
        __CrossClusterKeyword,
        __CrossDBKeyword,
        __IdKeyword,
        __IsFuzzyKeyword,
        __NoWithSourceKeyword,
        __PackedColumnKeyword,
        __SourceColumnIndexKeyword,
        _3DChartKeyword,

        AccessKeyword,
        AccumulateKeyword,
        AliasKeyword,
        AndKeyword,
        AnomalyChartKeyword,
        AreaChartKeyword,
        AsKeyword,
        AscKeyword,

        BagExpansionKeyword,
        BarChartKeyword,
        BetweenKeyword,
        BinKeyword,
        BinLegacy,
        ByKeyword,

        CachingPolicyKeyword,
        CalloutKeyword,
        CancelKeyword,
        CardKeyword,
        ColumnChartKeyword,
        CommandsAndQueriesKeyword,
        ConsumeKeyword,
        ContainsKeyword,
        ContainsCsKeyword,
        Contains_CsKeyword,
        ContextualDataTableKeyword,
        CountKeyword,

        DatabaseKeyword,
        DataExportKeyword,
        DataScopeKeyword,
        DataTableKeyword,
        DeclareKeyword,
        DecodeBlocksKeyword,
        DefaultKeyword,
        DescKeyword,
        DistinctKeyword,

        EarliestKeyword,
        EncodingPolicyKeyword,
        EndsWithKeyword,
        EndsWithCsKeyword,
        EntityGroupKeyword,
        EvaluateKeyword,
        ExecuteAndCacheKeyword,
        ExpandOutputKeyword,
        ExtendKeyword,
        ExtentTagsRetentionKeyword,
        ExternalDataKeyword,
        External_DataKeyword,

        FacetKeyword,
        FilterKeyword,
        FindKeyword,
        FirstKeyword,
        FlagsKeyword,
        ForkKeyword,
        FromKeyword,

        GetSchemaKeyword,
        GrannyAscKeyword,
        GrannyDescKeyword,

        HardDeleteKeyword,
        HardRetentionKeyword,
        HasKeyword,
        HasAnyKeyword,
        HasAllKeyword,
        HasCsKeyword,
        HasPrefixKeyword,
        HasPrefixCsKeyword,
        HasSuffixKeyword,
        HasSuffixCsKeyword,
        HintDotConcurrencyKeyword,
        HintDotDistributionKeyword,
        HintDotMaterializedKeyword,
        HintDotNumPartitions,
        HintDotShuffleKeyKeyword,
        HintDotSpreadKeyword,
        HintDotRemoteKeyword,
        HintDotStrategyKeyword,
        HintDotProgressiveTopKeyword,
        HotCacheKeyword,

        IdKeyword,
        InKeyword,
        InCsKeyword,
        InvokeKeyword,
        IsFuzzyKeyword,

        JoinKeyword,
        JournalKeyword,

        KindKeyword,

        LadderChartKeyword,
        LastKeyword,
        LatestKeyword,
        LetKeyword,
        LikeKeyword,
        LikeCsKeyword,
        LimitKeyword,
        LineChartKeyword,
        LookupKeyword,

        MakeSeriesKeyword,
        MatchesRegexKeyword,
        MaterializeKeyword,
        MaterializedViewCombineKeyword,
        MaterializedViewsKeyword,
        MdmKeyword,
        MissingKeyword,
        MvApplyKeyword,
        MvDashApplyKeyword,
        MvDashExpandKeyword,
        MvExpandKeyword,

        NoOptimizationKeyword,
        NotBetweenKeyword,
        NotContainsKeyword,
        NotContainsCsKeyword,
        NotBangContainsKeyword,
        NotBangContainsCsKeyword,
        NotEndsWithKeyword,
        NotEndsWithCsKeyword,
        NotHasKeyword,
        NotHasCsKeyword,
        NotHasPrefixKeyword,
        NotHasPrefixCsKeyword,
        NotHasSuffixKeyword,
        NotHasSuffixCsKeyword,
        NotInKeyword,
        NotInCsKeyword,
        NotLikeKeyword,
        NotLikeCsKeyword,
        NotStartsWithKeyword,
        NotStartsWithCsKeyword,
        NullKeyword,
        NullsKeyword,

        OfKeyword,
        OnKeyword,
        OptionalKeyword,
        OrKeyword,
        OrderKeyword,
        OthersKeyword,
        OutputKeyword,

        PackKeyword,
        ParseKeyword,
        ParseWhereKeyword,
        PartitionKeyword,
        PathFormatKeyword,
        PatternKeyword,
        PieChartKeyword,
        PivotChartKeyword,
        PrintKeyword,
        ProjectKeyword,
        ProjectAwayKeyword,
        _ProjectAwayKeyword,
        ProjectKeepKeyword,
        ProjectRenameKeyword,
        ProjectReorderKeyword,
        ProjectSmartKeyword,

        QueriesKeyword,
        QueryParametersKeyword,
        QueryResultsKeyword,

        RangeKeyword,
        ReduceKeyword,
        RegexKeyword,
        RelaxedKeyword,
        RenderKeyword,
        RestrictedViewAccessKeyword,
        RestrictKeyword,
        RowLevelSecurityKeyword,
        RowstoreKeyword,
        RowstoreReferencesKeyword,
        RowstoreSealInfoKeyword,
        RowstorePolicyKeyword,
        RowstoresKeyword,

        SampleKeyword,
        SampleDistinctKeyword,
        ScanKeyword,
        ScatterChartKeyword,
        SealKeyword,
        SealsKeyword,
        SearchKeyword,
        SerializeKeyword,
        SetKeyword,
        SetOrAppendKeyword,
        SetOrReplaceKeyword,
        ShardsKeyword,
        SimpleKeyword,
        SoftDeleteKeyword,
        SoftRetentionKeyword,
        SortKeyword,
        SqlKeyword,
        StackedAreaChartKeyword,
        StartsWithKeyword,
        StartsWithCsKeyword,
        StatisticsKeyword,
        StepKeyword,
        StoredQueryResultContainersKeyword,
        SummarizeKeyword,

        TablePurgeKeyword,
        TakeKeyword,
        TimeChartKeyword,
        TimelineKeyword,
        TimePivotKeyword,
        TitleKeyword,
        ToKeyword,
        TopKeyword,
        TopHittersKeyword,
        TopNestedKeyword,
        ToScalarKeyword,
        ToTableKeyword,
        TreeMapKeyword,
        TypeOfKeyword,

        UnionKeyword,
        UnrestrictedViewersKeyword,
        UuidKeyword,

        VerboseKeyword,
        ViewersKeyword,
        ViewKeyword,
        ViewsKeyword,

        WhereKeyword,
        WithItemIndexKeyword,
        WithKeyword,
        WithMatchIdKeyword,
        With_SourceKeyword,
        WithStepNameKeyword,
        WithSourceKeyword,
        WriteAheadLogKeyword,

        // scalar type keyword tokens
        BoolKeyword,
        BooleanKeyword,
        Int8Keyword,
        CharKeyword,
        UInt8Keyword,
        ByteKeyword,
        Int16Keyword,
        UInt16Keyword,
        IntKeyword,
        Int32Keyword,
        UIntKeyword,
        UInt32Keyword,
        LongKeyword,
        Int64Keyword,
        ULongKeyword,
        UInt64Keyword,
        SingleKeyword,
        FloatKeyword,
        RealKeyword,
        DecimalKeyword,
        DoubleKeyword,
        StringKeyword,
        TimeKeyword,
        TimespanKeyword,
        DateKeyword,
        DateTimeKeyword,
        GuidKeyword,
        UniqueIdKeyword,
        DynamicKeyword,

        // punctuation tokens
        OpenParenToken,
        CloseParenToken,
        OpenBracketToken,
        CloseBracketToken,
        OpenBraceToken,
        CloseBraceToken,
        BarToken,
        LessThanBarToken,
        PlusToken,
        MinusToken,
        AsteriskToken,
        SlashToken,
        PercentToken,
        DotToken,
        DotDotToken,
        BangToken,
        LessThanToken,
        LessThanOrEqualToken,
        GreaterThanToken,
        GreaterThanOrEqualToken,
        EqualToken,
        EqualEqualToken,
        BangEqualToken,
        LessThanGreaterThanToken,
        ColonToken,
        SemicolonToken,
        CommaToken,
        EqualTildeToken,
        BangTildeToken,
        AtToken,
        QuestionToken,
        FatArrowToken,

        // literal tokens
        BooleanLiteralToken,
        IntLiteralToken,
        LongLiteralToken,
        RealLiteralToken,
        DecimalLiteralToken,
        DateTimeLiteralToken,
        TimespanLiteralToken,
        GuidLiteralToken,
        StringLiteralToken,

        // other tokens
        IdentifierToken,
        DirectiveToken,
        EndOfTextToken,
        BadToken,

        // nodes
        List,
        SeparatedElement,
        ExpressionList,
        ExpressionCouple,
        RenameList,
        CustomNode,

        // literal expressions (kinds for LiteralExpression node)
        BooleanLiteralExpression,
        IntLiteralExpression,
        LongLiteralExpression,
        RealLiteralExpression,
        DecimalLiteralExpression,
        DateTimeLiteralExpression,
        TimespanLiteralExpression,
        GuidLiteralExpression,
        StringLiteralExpression,
        NullLiteralExpression,
        TokenLiteralExpression,  // any token (keyword/identifier/etc)

        // special literal expressions (each has own type)
        CompoundStringLiteralExpression,
        TypeOfLiteralExpression,

        // dynamic/json expressions
        DynamicExpression,
        JsonObjectExpression,
        JsonPair,
        JsonArrayExpression,

        // names
        TokenName,
        BracketedName,
        BracedName, // client parameters
        WildcardedName,
        BracketedWildcardedName,
        NameDeclaration,
        NameReference,

        ParenthesizedExpression,
        PathExpression,
        ElementExpression,
        SimpleNamedExpression,
        CompoundNamedExpression,
        FunctionCallExpression,
        ToScalarExpression,
        ToTableExpression,
        BracketedExpression,
        PipeExpression,
        NamedParameter,
        DataScopeExpression,
        DataTableExpression,
        ContextualDataTableExpression,
        ExternalDataExpression,
        ExternalDataWithClause,
        ExternalDataUriList,
        MaterializedViewCombineExpression,
        MaterializedViewCombineClause,

        // nullary?
        StarExpression,
        AtExpression,

        // unary operators
        UnaryPlusExpression,
        UnaryMinusExpression,

        // binary operators
        AddExpression,
        SubtractExpression,
        MultiplyExpression,
        DivideExpression,
        ModuloExpression,
        LessThanExpression,
        LessThanOrEqualExpression,
        GreaterThanExpression,
        GreaterThanOrEqualExpression,
        EqualExpression,
        NotEqualExpression,
        AndExpression,
        OrExpression,
        InExpression,
        InCsExpression,
        NotInExpression,
        NotInCsExpression,
        BetweenExpression,
        NotBetweenExpression,

        // string binary operators
        EqualTildeExpression, // equal - ignore case
        BangTildeExpression,  // not equal - ignore case
        HasExpression,
        HasCsExpression,
        NotHasExpression,
        NotHasCsExpression,
        HasPrefixExpression,
        HasPrefixCsExpression,
        NotHasPrefixExpression,
        NotHasPrefixCsExpression,
        HasSuffixExpression,
        HasSuffixCsExpression,
        NotHasSuffixExpression,
        NotHasSuffixCsExpression,
        LikeExpression,
        LikeCsExpression,
        NotLikeExpression,
        NotLikeCsExpression,
        ContainsExpression,
        ContainsCsExpression,
        NotContainsExpression,
        NotContainsCsExpression,
        StartsWithExpression,
        StartsWithCsExpression,
        NotStartsWithExpression,
        NotStartsWithCsExpression,
        EndsWithExpression,
        EndsWithCsExpression,
        NotEndsWithExpression,
        NotEndsWithCsExpression,
        MatchesRegexExpression,
        SearchExpression,
        HasAnyExpression,
        HasAllExpression,

        // common command-related expressions & clauses
        TypedColumnReference,
        PackExpression,
        NameAndTypeDeclaration,
        PrimitiveTypeExpression,
        SchemaTypeExpression,
        NameEqualsClause,
        DefaultExpressionClause,
        ToTypeOfClause,
        EvaluateSchemaClause,

        // query operators
        BadQueryOperator,

        AsOperator,

        ConsumeOperator,

        CountOperator,
        CountAsIdentifierClause,

        DistinctOperator,

        ExecuteAndCacheOperator,
        ExtendOperator,

        FacetOperator,
        FacetWithOperatorClause,
        FacetWithExpressionClause,

        FilterOperator,
        FindOperator,
        DataScopeClause,
        FindInClause,
        FindProjectClause,

        GetSchemaOperator,

        InvokeOperator,

        LookupOperator,
        JoinOperator,
        JoinOnClause,
        JoinWhereClause,

        SearchOperator,

        ForkOperator,
        ForkExpression,

        MakeSeriesOperator,
        MakeSeriesExpression,
        MakeSeriesOnClause,
        MakeSeriesInRangeClause,
        MakeSeriesFromClause,
        MakeSeriesToClause,
        MakeSeriesStepClause,
        MakeSeriesFromToStepClause,
        MakeSeriesByClause,

        MvApplyOperator,
        MvApplyExpression,
        MvApplyRowLimitClause,
        MvApplyContextIdClause,
        MvApplySubqueryExpression,

        MvExpandOperator,
        MvExpandExpression,
        MvExpandRowLimitClause,

        PartitionSubquery,
        PartitionQuery,
        PartitionScope,
        PartitionOperator,
        ParseOperator,
        ParseWhereOperator,

        EvaluateOperator,

        ProjectOperator,
        ProjectAwayOperator,
        ProjectKeepOperator,
        ProjectRenameOperator,
        ProjectReorderOperator,

        RangeOperator,

        ReduceByOperator,
        ReduceByWithClause,

        RenderOperator,
        RenderWithClause,
        NameReferenceList,

        SampleOperator,
        SampleDistinctOperator,

        ScanOperator,
        ScanOrderByClause,
        ScanPartitionByClause,
        ScanDeclareClause,
        ScanStep,
        ScanStepOutput,
        ScanComputationClause,
        ScanAssignment,

        SerializeOperator,

        SortOperator,
        OrderedExpression,
        OrderingClause,
        OrderingNullsClause,

        SummarizeOperator,
        SummarizeByClause,

        TakeOperator,

        TopHittersOperator,
        TopHittersByClause,
        TopOperator,
        TopNestedOperator,
        TopNestedClause,
        TopNestedWithOthersClause,

        UnionOperator,

        PrintOperator,

        // statements
        AliasStatement,

        ExpressionStatement,

        FunctionDeclaration,
        FunctionParameters,
        FunctionParameter,
        DefaultValueDeclaration,
        FunctionBody,

        LetStatement,

        MaterializeExpression,

        RestrictStatement,

        SetOptionStatement,
        OptionValueClause,

        PatternStatement,
        PatternDeclaration,
        PatternPathParameter,
        PatternMatch,
        PatternPathValue,

        QueryParametersStatement,

        // commands
        CommandWithValueClause,
        CommandWithPropertyListClause,
        BadCommand,
        UnknownCommand,
        CustomCommand,

        // other
        QueryBlock,
        CommandBlock,
        DirectiveBlock,
        SkippedTokens,
        InputTextToken,
    }
}