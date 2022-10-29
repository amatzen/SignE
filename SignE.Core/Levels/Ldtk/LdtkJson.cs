﻿namespace ldtk
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// This file is a JSON schema of files created by LDtk level editor (https://ldtk.io).
    ///
    /// This is the root of any Project JSON file. It contains:  - the project settings, - an
    /// array of levels, - a group of definitions (that can probably be safely ignored for most
    /// users).
    /// </summary>
    public partial class LdtkJson
    {
        /// <summary>
        /// This object is not actually used by LDtk. It ONLY exists to force explicit references to
        /// all types, to make sure QuickType finds them and integrate all of them. Otherwise,
        /// Quicktype will drop types that are not explicitely used.
        /// </summary>
        [JsonProperty("__FORCED_REFS", NullValueHandling = NullValueHandling.Ignore)]
        public ForcedRefs ForcedRefs { get; set; }

        /// <summary>
        /// LDtk application build identifier.<br/>  This is only used to identify the LDtk version
        /// that generated this particular project file, which can be useful for specific bug fixing.
        /// Note that the build identifier is just the date of the release, so it's not unique to
        /// each user (one single global ID per LDtk public release), and as a result, completely
        /// anonymous.
        /// </summary>
        [JsonProperty("appBuildId")]
        public double AppBuildId { get; set; }

        /// <summary>
        /// Number of backup files to keep, if the `backupOnSave` is TRUE
        /// </summary>
        [JsonProperty("backupLimit")]
        public long BackupLimit { get; set; }

        /// <summary>
        /// If TRUE, an extra copy of the project will be created in a sub folder, when saving.
        /// </summary>
        [JsonProperty("backupOnSave")]
        public bool BackupOnSave { get; set; }

        /// <summary>
        /// Project background color
        /// </summary>
        [JsonProperty("bgColor")]
        public string BgColor { get; set; }

        /// <summary>
        /// Default grid size for new layers
        /// </summary>
        [JsonProperty("defaultGridSize")]
        public long DefaultGridSize { get; set; }

        /// <summary>
        /// Default background color of levels
        /// </summary>
        [JsonProperty("defaultLevelBgColor")]
        public string DefaultLevelBgColor { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Default new level height
        /// </summary>
        [JsonProperty("defaultLevelHeight")]
        public long? DefaultLevelHeight { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Default new level width
        /// </summary>
        [JsonProperty("defaultLevelWidth")]
        public long? DefaultLevelWidth { get; set; }

        /// <summary>
        /// Default X pivot (0 to 1) for new entities
        /// </summary>
        [JsonProperty("defaultPivotX")]
        public double DefaultPivotX { get; set; }

        /// <summary>
        /// Default Y pivot (0 to 1) for new entities
        /// </summary>
        [JsonProperty("defaultPivotY")]
        public double DefaultPivotY { get; set; }

        /// <summary>
        /// A structure containing all the definitions of this project
        /// </summary>
        [JsonProperty("defs")]
        public Definitions Defs { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 0.9.3  Replaced
        /// by: `imageExportMode`
        /// </summary>
        [JsonProperty("exportPng")]
        public bool? ExportPng { get; set; }

        /// <summary>
        /// If TRUE, a Tiled compatible file will also be generated along with the LDtk JSON file
        /// (default is FALSE)
        /// </summary>
        [JsonProperty("exportTiled")]
        public bool ExportTiled { get; set; }

        /// <summary>
        /// If TRUE, one file will be saved for the project (incl. all its definitions) and one file
        /// in a sub-folder for each level.
        /// </summary>
        [JsonProperty("externalLevels")]
        public bool ExternalLevels { get; set; }

        /// <summary>
        /// An array containing various advanced flags (ie. options or other states). Possible
        /// values: `DiscardPreCsvIntGrid`, `ExportPreCsvIntGridFormat`, `IgnoreBackupSuggest`,
        /// `PrependIndexToLevelFileNames`, `MultiWorlds`, `UseMultilinesType`
        /// </summary>
        [JsonProperty("flags")]
        public Flag[] Flags { get; set; }

        /// <summary>
        /// Naming convention for Identifiers (first-letter uppercase, full uppercase etc.) Possible
        /// values: `Capitalize`, `Uppercase`, `Lowercase`, `Free`
        /// </summary>
        [JsonProperty("identifierStyle")]
        public IdentifierStyle IdentifierStyle { get; set; }

        /// <summary>
        /// "Image export" option when saving project. Possible values: `None`, `OneImagePerLayer`,
        /// `OneImagePerLevel`, `LayersAndLevels`
        /// </summary>
        [JsonProperty("imageExportMode")]
        public ImageExportMode ImageExportMode { get; set; }

        /// <summary>
        /// File format version
        /// </summary>
        [JsonProperty("jsonVersion")]
        public string JsonVersion { get; set; }

        /// <summary>
        /// The default naming convention for level identifiers.
        /// </summary>
        [JsonProperty("levelNamePattern")]
        public string LevelNamePattern { get; set; }

        /// <summary>
        /// All levels. The order of this array is only relevant in `LinearHorizontal` and
        /// `linearVertical` world layouts (see `worldLayout` value).<br/>  Otherwise, you should
        /// refer to the `worldX`,`worldY` coordinates of each Level.
        /// </summary>
        [JsonProperty("levels")]
        public Level[] Levels { get; set; }

        /// <summary>
        /// If TRUE, the Json is partially minified (no indentation, nor line breaks, default is
        /// FALSE)
        /// </summary>
        [JsonProperty("minifyJson")]
        public bool MinifyJson { get; set; }

        /// <summary>
        /// Next Unique integer ID available
        /// </summary>
        [JsonProperty("nextUid")]
        public long NextUid { get; set; }

        /// <summary>
        /// File naming pattern for exported PNGs
        /// </summary>
        [JsonProperty("pngFilePattern")]
        public string PngFilePattern { get; set; }

        /// <summary>
        /// If TRUE, a very simplified will be generated on saving, for quicker & easier engine
        /// integration.
        /// </summary>
        [JsonProperty("simplifiedExport")]
        public bool SimplifiedExport { get; set; }

        /// <summary>
        /// This optional description is used by LDtk Samples to show up some informations and
        /// instructions.
        /// </summary>
        [JsonProperty("tutorialDesc")]
        public string TutorialDesc { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Height of the world grid in pixels.
        /// </summary>
        [JsonProperty("worldGridHeight")]
        public long? WorldGridHeight { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  Width of the world grid in pixels.
        /// </summary>
        [JsonProperty("worldGridWidth")]
        public long? WorldGridWidth { get; set; }

        /// <summary>
        /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
        /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
        /// the change immediately.<br/><br/>  An enum that describes how levels are organized in
        /// this project (ie. linearly or in a 2D space). Possible values: &lt;`null`&gt;, `Free`,
        /// `GridVania`, `LinearHorizontal`, `LinearVertical`
        /// </summary>
        [JsonProperty("worldLayout")]
        public WorldLayout? WorldLayout { get; set; }

        /// <summary>
        /// This array is not used yet in current LDtk version (so, for now, it's always
        /// empty).<br/><br/>In a later update, it will be possible to have multiple Worlds in a
        /// single project, each containing multiple Levels.<br/><br/>What will change when "Multiple
        /// worlds" support will be added to LDtk:<br/><br/> - in current version, a LDtk project
        /// file can only contain a single world with multiple levels in it. In this case, levels and
        /// world layout related settings are stored in the root of the JSON.<br/> - after the
        /// "Multiple worlds" update, there will be a `worlds` array in root, each world containing
        /// levels and layout settings. Basically, it's pretty much only about moving the `levels`
        /// array to the `worlds` array, along with world layout related values (eg. `worldGridWidth`
        /// etc).<br/><br/>If you want to start supporting this future update easily, please refer to
        /// this documentation: https://github.com/deepnight/ldtk/issues/231
        /// </summary>
        [JsonProperty("worlds")]
        public World[] Worlds { get; set; }
    }

    /// <summary>
    /// If you're writing your own LDtk importer, you should probably just ignore *most* stuff in
    /// the `defs` section, as it contains data that are mostly important to the editor. To keep
    /// you away from the `defs` section and avoid some unnecessary JSON parsing, important data
    /// from definitions is often duplicated in fields prefixed with a double underscore (eg.
    /// `__identifier` or `__type`).  The 2 only definition types you might need here are
    /// **Tilesets** and **Enums**.
    ///
    /// A structure containing all the definitions of this project
    /// </summary>
    public partial class Definitions
    {
        /// <summary>
        /// All entities definitions, including their custom fields
        /// </summary>
        [JsonProperty("entities")]
        public EntityDefinition[] Entities { get; set; }

        /// <summary>
        /// All internal enums
        /// </summary>
        [JsonProperty("enums")]
        public EnumDefinition[] Enums { get; set; }

        /// <summary>
        /// Note: external enums are exactly the same as `enums`, except they have a `relPath` to
        /// point to an external source file.
        /// </summary>
        [JsonProperty("externalEnums")]
        public EnumDefinition[] ExternalEnums { get; set; }

        /// <summary>
        /// All layer definitions
        /// </summary>
        [JsonProperty("layers")]
        public LayerDefinition[] Layers { get; set; }

        /// <summary>
        /// All custom fields available to all levels.
        /// </summary>
        [JsonProperty("levelFields")]
        public FieldDefinition[] LevelFields { get; set; }

        /// <summary>
        /// All tilesets
        /// </summary>
        [JsonProperty("tilesets")]
        public TilesetDefinition[] Tilesets { get; set; }
    }

    public partial class EntityDefinition
    {
        /// <summary>
        /// Base entity color
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// Array of field definitions
        /// </summary>
        [JsonProperty("fieldDefs")]
        public FieldDefinition[] FieldDefs { get; set; }

        [JsonProperty("fillOpacity")]
        public double FillOpacity { get; set; }

        /// <summary>
        /// Pixel height
        /// </summary>
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("hollow")]
        public bool Hollow { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Only applies to entities resizable on both X/Y. If TRUE, the entity instance width/height
        /// will keep the same aspect ratio as the definition.
        /// </summary>
        [JsonProperty("keepAspectRatio")]
        public bool KeepAspectRatio { get; set; }

        /// <summary>
        /// Possible values: `DiscardOldOnes`, `PreventAdding`, `MoveLastOne`
        /// </summary>
        [JsonProperty("limitBehavior")]
        public LimitBehavior LimitBehavior { get; set; }

        /// <summary>
        /// If TRUE, the maxCount is a "per world" limit, if FALSE, it's a "per level". Possible
        /// values: `PerLayer`, `PerLevel`, `PerWorld`
        /// </summary>
        [JsonProperty("limitScope")]
        public LimitScope LimitScope { get; set; }

        [JsonProperty("lineOpacity")]
        public double LineOpacity { get; set; }

        /// <summary>
        /// Max instances count
        /// </summary>
        [JsonProperty("maxCount")]
        public long MaxCount { get; set; }

        /// <summary>
        /// An array of 4 dimensions for the up/right/down/left borders (in this order) when using
        /// 9-slice mode for `tileRenderMode`.<br/>  If the tileRenderMode is not NineSlice, then
        /// this array is empty.<br/>  See: https://en.wikipedia.org/wiki/9-slice_scaling
        /// </summary>
        [JsonProperty("nineSliceBorders")]
        public long[] NineSliceBorders { get; set; }

        /// <summary>
        /// Pivot X coordinate (from 0 to 1.0)
        /// </summary>
        [JsonProperty("pivotX")]
        public double PivotX { get; set; }

        /// <summary>
        /// Pivot Y coordinate (from 0 to 1.0)
        /// </summary>
        [JsonProperty("pivotY")]
        public double PivotY { get; set; }

        /// <summary>
        /// Possible values: `Rectangle`, `Ellipse`, `Tile`, `Cross`
        /// </summary>
        [JsonProperty("renderMode")]
        public RenderMode RenderMode { get; set; }

        /// <summary>
        /// If TRUE, the entity instances will be resizable horizontally
        /// </summary>
        [JsonProperty("resizableX")]
        public bool ResizableX { get; set; }

        /// <summary>
        /// If TRUE, the entity instances will be resizable vertically
        /// </summary>
        [JsonProperty("resizableY")]
        public bool ResizableY { get; set; }

        /// <summary>
        /// Display entity name in editor
        /// </summary>
        [JsonProperty("showName")]
        public bool ShowName { get; set; }

        /// <summary>
        /// An array of strings that classifies this entity
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value will be *removed* completely on version 1.2.0+
        /// Replaced by: `tileRect`
        /// </summary>
        [JsonProperty("tileId")]
        public long? TileId { get; set; }

        [JsonProperty("tileOpacity")]
        public double TileOpacity { get; set; }

        /// <summary>
        /// An object representing a rectangle from an existing Tileset
        /// </summary>
        [JsonProperty("tileRect")]
        public TilesetRectangle TileRect { get; set; }

        /// <summary>
        /// An enum describing how the the Entity tile is rendered inside the Entity bounds. Possible
        /// values: `Cover`, `FitInside`, `Repeat`, `Stretch`, `FullSizeCropped`,
        /// `FullSizeUncropped`, `NineSlice`
        /// </summary>
        [JsonProperty("tileRenderMode")]
        public TileRenderMode TileRenderMode { get; set; }

        /// <summary>
        /// Tileset ID used for optional tile display
        /// </summary>
        [JsonProperty("tilesetId")]
        public long? TilesetId { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonProperty("uid")]
        public long Uid { get; set; }

        /// <summary>
        /// Pixel width
        /// </summary>
        [JsonProperty("width")]
        public long Width { get; set; }
    }

    /// <summary>
    /// This section is mostly only intended for the LDtk editor app itself. You can safely
    /// ignore it.
    /// </summary>
    public partial class FieldDefinition
    {
        /// <summary>
        /// Human readable value type. Possible values: `Int, Float, String, Bool, Color,
        /// ExternEnum.XXX, LocalEnum.XXX, Point, FilePath`.<br/>  If the field is an array, this
        /// field will look like `Array<...>` (eg. `Array<Int>`, `Array<Point>` etc.)<br/>  NOTE: if
        /// you enable the advanced option **Use Multilines type**, you will have "*Multilines*"
        /// instead of "*String*" when relevant.
        /// </summary>
        [JsonProperty("__type")]
        public string Type { get; set; }

        /// <summary>
        /// Optional list of accepted file extensions for FilePath value type. Includes the dot:
        /// `.ext`
        /// </summary>
        [JsonProperty("acceptFileTypes")]
        public string[] AcceptFileTypes { get; set; }

        /// <summary>
        /// Possible values: `Any`, `OnlySame`, `OnlyTags`
        /// </summary>
        [JsonProperty("allowedRefs")]
        public AllowedRefs AllowedRefs { get; set; }

        [JsonProperty("allowedRefTags")]
        public string[] AllowedRefTags { get; set; }

        [JsonProperty("allowOutOfLevelRef")]
        public bool AllowOutOfLevelRef { get; set; }

        /// <summary>
        /// Array max length
        /// </summary>
        [JsonProperty("arrayMaxLength")]
        public long? ArrayMaxLength { get; set; }

        /// <summary>
        /// Array min length
        /// </summary>
        [JsonProperty("arrayMinLength")]
        public long? ArrayMinLength { get; set; }

        [JsonProperty("autoChainRef")]
        public bool AutoChainRef { get; set; }

        /// <summary>
        /// TRUE if the value can be null. For arrays, TRUE means it can contain null values
        /// (exception: array of Points can't have null values).
        /// </summary>
        [JsonProperty("canBeNull")]
        public bool CanBeNull { get; set; }

        /// <summary>
        /// Default value if selected value is null or invalid.
        /// </summary>
        [JsonProperty("defaultOverride")]
        public dynamic DefaultOverride { get; set; }

        [JsonProperty("editorAlwaysShow")]
        public bool EditorAlwaysShow { get; set; }

        [JsonProperty("editorCutLongValues")]
        public bool EditorCutLongValues { get; set; }

        /// <summary>
        /// Possible values: `Hidden`, `ValueOnly`, `NameAndValue`, `EntityTile`, `Points`,
        /// `PointStar`, `PointPath`, `PointPathLoop`, `RadiusPx`, `RadiusGrid`,
        /// `ArrayCountWithLabel`, `ArrayCountNoLabel`, `RefLinkBetweenPivots`,
        /// `RefLinkBetweenCenters`
        /// </summary>
        [JsonProperty("editorDisplayMode")]
        public EditorDisplayMode EditorDisplayMode { get; set; }

        /// <summary>
        /// Possible values: `Above`, `Center`, `Beneath`
        /// </summary>
        [JsonProperty("editorDisplayPos")]
        public EditorDisplayPos EditorDisplayPos { get; set; }

        [JsonProperty("editorTextPrefix")]
        public string EditorTextPrefix { get; set; }

        [JsonProperty("editorTextSuffix")]
        public string EditorTextSuffix { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// TRUE if the value is an array of multiple values
        /// </summary>
        [JsonProperty("isArray")]
        public bool IsArray { get; set; }

        /// <summary>
        /// Max limit for value, if applicable
        /// </summary>
        [JsonProperty("max")]
        public double? Max { get; set; }

        /// <summary>
        /// Min limit for value, if applicable
        /// </summary>
        [JsonProperty("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Optional regular expression that needs to be matched to accept values. Expected format:
        /// `/some_reg_ex/g`, with optional "i" flag.
        /// </summary>
        [JsonProperty("regex")]
        public string Regex { get; set; }

        [JsonProperty("symmetricalRef")]
        public bool SymmetricalRef { get; set; }

        /// <summary>
        /// Possible values: &lt;`null`&gt;, `LangPython`, `LangRuby`, `LangJS`, `LangLua`, `LangC`,
        /// `LangHaxe`, `LangMarkdown`, `LangJson`, `LangXml`, `LangLog`
        /// </summary>
        [JsonProperty("textLanguageMode")]
        public TextLanguageMode? TextLanguageMode { get; set; }

        /// <summary>
        /// UID of the tileset used for a Tile
        /// </summary>
        [JsonProperty("tilesetUid")]
        public long? TilesetUid { get; set; }

        /// <summary>
        /// Internal enum representing the possible field types. Possible values: F_Int, F_Float,
        /// F_String, F_Text, F_Bool, F_Color, F_Enum(...), F_Point, F_Path, F_EntityRef, F_Tile
        /// </summary>
        [JsonProperty("type")]
        public string FieldDefinitionType { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonProperty("uid")]
        public long Uid { get; set; }

        /// <summary>
        /// If TRUE, the color associated with this field will override the Entity or Level default
        /// color in the editor UI. For Enum fields, this would be the color associated to their
        /// values.
        /// </summary>
        [JsonProperty("useForSmartColor")]
        public bool UseForSmartColor { get; set; }
    }

    /// <summary>
    /// This object represents a custom sub rectangle in a Tileset image.
    /// </summary>
    public partial class TilesetRectangle
    {
        /// <summary>
        /// Height in pixels
        /// </summary>
        [JsonProperty("h")]
        public long H { get; set; }

        /// <summary>
        /// UID of the tileset
        /// </summary>
        [JsonProperty("tilesetUid")]
        public long TilesetUid { get; set; }

        /// <summary>
        /// Width in pixels
        /// </summary>
        [JsonProperty("w")]
        public long W { get; set; }

        /// <summary>
        /// X pixels coordinate of the top-left corner in the Tileset image
        /// </summary>
        [JsonProperty("x")]
        public long X { get; set; }

        /// <summary>
        /// Y pixels coordinate of the top-left corner in the Tileset image
        /// </summary>
        [JsonProperty("y")]
        public long Y { get; set; }
    }

    public partial class EnumDefinition
    {
        [JsonProperty("externalFileChecksum")]
        public string ExternalFileChecksum { get; set; }

        /// <summary>
        /// Relative path to the external file providing this Enum
        /// </summary>
        [JsonProperty("externalRelPath")]
        public string ExternalRelPath { get; set; }

        /// <summary>
        /// Tileset UID if provided
        /// </summary>
        [JsonProperty("iconTilesetUid")]
        public long? IconTilesetUid { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// An array of user-defined tags to organize the Enums
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonProperty("uid")]
        public long Uid { get; set; }

        /// <summary>
        /// All possible enum values, with their optional Tile infos.
        /// </summary>
        [JsonProperty("values")]
        public EnumValueDefinition[] Values { get; set; }
    }

    public partial class EnumValueDefinition
    {
        /// <summary>
        /// An array of 4 Int values that refers to the tile in the tileset image: `[ x, y, width,
        /// height ]`
        /// </summary>
        [JsonProperty("__tileSrcRect")]
        public long[] TileSrcRect { get; set; }

        /// <summary>
        /// Optional color
        /// </summary>
        [JsonProperty("color")]
        public long Color { get; set; }

        /// <summary>
        /// Enum value
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The optional ID of the tile
        /// </summary>
        [JsonProperty("tileId")]
        public long? TileId { get; set; }
    }

    public partial class LayerDefinition
    {
        /// <summary>
        /// Type of the layer (*IntGrid, Entities, Tiles or AutoLayer*)
        /// </summary>
        [JsonProperty("__type")]
        public string Type { get; set; }

        /// <summary>
        /// Contains all the auto-layer rule definitions.
        /// </summary>
        [JsonProperty("autoRuleGroups")]
        public AutoLayerRuleGroup[] AutoRuleGroups { get; set; }

        [JsonProperty("autoSourceLayerDefUid")]
        public long? AutoSourceLayerDefUid { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value will be *removed* completely on version 1.2.0+
        /// Replaced by: `tilesetDefUid`
        /// </summary>
        [JsonProperty("autoTilesetDefUid")]
        public long? AutoTilesetDefUid { get; set; }

        /// <summary>
        /// Opacity of the layer (0 to 1.0)
        /// </summary>
        [JsonProperty("displayOpacity")]
        public double DisplayOpacity { get; set; }

        /// <summary>
        /// An array of tags to forbid some Entities in this layer
        /// </summary>
        [JsonProperty("excludedTags")]
        public string[] ExcludedTags { get; set; }

        /// <summary>
        /// Width and height of the grid in pixels
        /// </summary>
        [JsonProperty("gridSize")]
        public long GridSize { get; set; }

        /// <summary>
        /// Height of the optional "guide" grid in pixels
        /// </summary>
        [JsonProperty("guideGridHei")]
        public long GuideGridHei { get; set; }

        /// <summary>
        /// Width of the optional "guide" grid in pixels
        /// </summary>
        [JsonProperty("guideGridWid")]
        public long GuideGridWid { get; set; }

        [JsonProperty("hideFieldsWhenInactive")]
        public bool HideFieldsWhenInactive { get; set; }

        /// <summary>
        /// Hide the layer from the list on the side of the editor view.
        /// </summary>
        [JsonProperty("hideInList")]
        public bool HideInList { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Alpha of this layer when it is not the active one.
        /// </summary>
        [JsonProperty("inactiveOpacity")]
        public double InactiveOpacity { get; set; }

        /// <summary>
        /// An array that defines extra optional info for each IntGrid value.<br/>  WARNING: the
        /// array order is not related to actual IntGrid values! As user can re-order IntGrid values
        /// freely, you may value "2" before value "1" in this array.
        /// </summary>
        [JsonProperty("intGridValues")]
        public IntGridValueDefinition[] IntGridValues { get; set; }

        /// <summary>
        /// Parallax horizontal factor (from -1 to 1, defaults to 0) which affects the scrolling
        /// speed of this layer, creating a fake 3D (parallax) effect.
        /// </summary>
        [JsonProperty("parallaxFactorX")]
        public double ParallaxFactorX { get; set; }

        /// <summary>
        /// Parallax vertical factor (from -1 to 1, defaults to 0) which affects the scrolling speed
        /// of this layer, creating a fake 3D (parallax) effect.
        /// </summary>
        [JsonProperty("parallaxFactorY")]
        public double ParallaxFactorY { get; set; }

        /// <summary>
        /// If true (default), a layer with a parallax factor will also be scaled up/down accordingly.
        /// </summary>
        [JsonProperty("parallaxScaling")]
        public bool ParallaxScaling { get; set; }

        /// <summary>
        /// X offset of the layer, in pixels (IMPORTANT: this should be added to the `LayerInstance`
        /// optional offset)
        /// </summary>
        [JsonProperty("pxOffsetX")]
        public long PxOffsetX { get; set; }

        /// <summary>
        /// Y offset of the layer, in pixels (IMPORTANT: this should be added to the `LayerInstance`
        /// optional offset)
        /// </summary>
        [JsonProperty("pxOffsetY")]
        public long PxOffsetY { get; set; }

        /// <summary>
        /// An array of tags to filter Entities that can be added to this layer
        /// </summary>
        [JsonProperty("requiredTags")]
        public string[] RequiredTags { get; set; }

        /// <summary>
        /// If the tiles are smaller or larger than the layer grid, the pivot value will be used to
        /// position the tile relatively its grid cell.
        /// </summary>
        [JsonProperty("tilePivotX")]
        public double TilePivotX { get; set; }

        /// <summary>
        /// If the tiles are smaller or larger than the layer grid, the pivot value will be used to
        /// position the tile relatively its grid cell.
        /// </summary>
        [JsonProperty("tilePivotY")]
        public double TilePivotY { get; set; }

        /// <summary>
        /// Reference to the default Tileset UID being used by this layer definition.<br/>
        /// **WARNING**: some layer *instances* might use a different tileset. So most of the time,
        /// you should probably use the `__tilesetDefUid` value found in layer instances.<br/>  Note:
        /// since version 1.0.0, the old `autoTilesetDefUid` was removed and merged into this value.
        /// </summary>
        [JsonProperty("tilesetDefUid")]
        public long? TilesetDefUid { get; set; }

        /// <summary>
        /// Type of the layer as Haxe Enum Possible values: `IntGrid`, `Entities`, `Tiles`,
        /// `AutoLayer`
        /// </summary>
        [JsonProperty("type")]
        public TypeEnum LayerDefinitionType { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonProperty("uid")]
        public long Uid { get; set; }
    }

    public partial class AutoLayerRuleGroup
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// *This field was removed in 1.0.0 and should no longer be used.*
        /// </summary>
        [JsonProperty("collapsed")]
        public bool? Collapsed { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rules")]
        public AutoLayerRuleDefinition[] Rules { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }
    }

    /// <summary>
    /// This complex section isn't meant to be used by game devs at all, as these rules are
    /// completely resolved internally by the editor before any saving. You should just ignore
    /// this part.
    /// </summary>
    public partial class AutoLayerRuleDefinition
    {
        /// <summary>
        /// If FALSE, the rule effect isn't applied, and no tiles are generated.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// When TRUE, the rule will prevent other rules to be applied in the same cell if it matches
        /// (TRUE by default).
        /// </summary>
        [JsonProperty("breakOnMatch")]
        public bool BreakOnMatch { get; set; }

        /// <summary>
        /// Chances for this rule to be applied (0 to 1)
        /// </summary>
        [JsonProperty("chance")]
        public double Chance { get; set; }

        /// <summary>
        /// Checker mode Possible values: `None`, `Horizontal`, `Vertical`
        /// </summary>
        [JsonProperty("checker")]
        public Checker Checker { get; set; }

        /// <summary>
        /// If TRUE, allow rule to be matched by flipping its pattern horizontally
        /// </summary>
        [JsonProperty("flipX")]
        public bool FlipX { get; set; }

        /// <summary>
        /// If TRUE, allow rule to be matched by flipping its pattern vertically
        /// </summary>
        [JsonProperty("flipY")]
        public bool FlipY { get; set; }

        /// <summary>
        /// Default IntGrid value when checking cells outside of level bounds
        /// </summary>
        [JsonProperty("outOfBoundsValue")]
        public long? OutOfBoundsValue { get; set; }

        /// <summary>
        /// Rule pattern (size x size)
        /// </summary>
        [JsonProperty("pattern")]
        public long[] Pattern { get; set; }

        /// <summary>
        /// If TRUE, enable Perlin filtering to only apply rule on specific random area
        /// </summary>
        [JsonProperty("perlinActive")]
        public bool PerlinActive { get; set; }

        [JsonProperty("perlinOctaves")]
        public double PerlinOctaves { get; set; }

        [JsonProperty("perlinScale")]
        public double PerlinScale { get; set; }

        [JsonProperty("perlinSeed")]
        public double PerlinSeed { get; set; }

        /// <summary>
        /// X pivot of a tile stamp (0-1)
        /// </summary>
        [JsonProperty("pivotX")]
        public double PivotX { get; set; }

        /// <summary>
        /// Y pivot of a tile stamp (0-1)
        /// </summary>
        [JsonProperty("pivotY")]
        public double PivotY { get; set; }

        /// <summary>
        /// Pattern width & height. Should only be 1,3,5 or 7.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// Array of all the tile IDs. They are used randomly or as stamps, based on `tileMode` value.
        /// </summary>
        [JsonProperty("tileIds")]
        public long[] TileIds { get; set; }

        /// <summary>
        /// Defines how tileIds array is used Possible values: `Single`, `Stamp`
        /// </summary>
        [JsonProperty("tileMode")]
        public TileMode TileMode { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonProperty("uid")]
        public long Uid { get; set; }

        /// <summary>
        /// X cell coord modulo
        /// </summary>
        [JsonProperty("xModulo")]
        public long XModulo { get; set; }

        /// <summary>
        /// X cell start offset
        /// </summary>
        [JsonProperty("xOffset")]
        public long XOffset { get; set; }

        /// <summary>
        /// Y cell coord modulo
        /// </summary>
        [JsonProperty("yModulo")]
        public long YModulo { get; set; }

        /// <summary>
        /// Y cell start offset
        /// </summary>
        [JsonProperty("yOffset")]
        public long YOffset { get; set; }
    }

    /// <summary>
    /// IntGrid value definition
    /// </summary>
    public partial class IntGridValueDefinition
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The IntGrid value itself
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }
    }

    /// <summary>
    /// The `Tileset` definition is the most important part among project definitions. It
    /// contains some extra informations about each integrated tileset. If you only had to parse
    /// one definition section, that would be the one.
    /// </summary>
    public partial class TilesetDefinition
    {
        /// <summary>
        /// Grid-based height
        /// </summary>
        [JsonProperty("__cHei")]
        public long CHei { get; set; }

        /// <summary>
        /// Grid-based width
        /// </summary>
        [JsonProperty("__cWid")]
        public long CWid { get; set; }

        /// <summary>
        /// The following data is used internally for various optimizations. It's always synced with
        /// source image changes.
        /// </summary>
        [JsonProperty("cachedPixelData")]
        public System.Collections.Generic.Dictionary<string, dynamic> CachedPixelData { get; set; }

        /// <summary>
        /// An array of custom tile metadata
        /// </summary>
        [JsonProperty("customData")]
        public TileCustomMetadata[] CustomData { get; set; }

        /// <summary>
        /// If this value is set, then it means that this atlas uses an internal LDtk atlas image
        /// instead of a loaded one. Possible values: &lt;`null`&gt;, `LdtkIcons`
        /// </summary>
        [JsonProperty("embedAtlas")]
        public EmbedAtlas? EmbedAtlas { get; set; }

        /// <summary>
        /// Tileset tags using Enum values specified by `tagsSourceEnumId`. This array contains 1
        /// element per Enum value, which contains an array of all Tile IDs that are tagged with it.
        /// </summary>
        [JsonProperty("enumTags")]
        public EnumTagValue[] EnumTags { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Distance in pixels from image borders
        /// </summary>
        [JsonProperty("padding")]
        public long Padding { get; set; }

        /// <summary>
        /// Image height in pixels
        /// </summary>
        [JsonProperty("pxHei")]
        public long PxHei { get; set; }

        /// <summary>
        /// Image width in pixels
        /// </summary>
        [JsonProperty("pxWid")]
        public long PxWid { get; set; }

        /// <summary>
        /// Path to the source file, relative to the current project JSON file<br/>  It can be null
        /// if no image was provided, or when using an embed atlas.
        /// </summary>
        [JsonProperty("relPath")]
        public string RelPath { get; set; }

        /// <summary>
        /// Array of group of tiles selections, only meant to be used in the editor
        /// </summary>
        [JsonProperty("savedSelections")]
        public System.Collections.Generic.Dictionary<string, dynamic>[] SavedSelections { get; set; }

        /// <summary>
        /// Space in pixels between all tiles
        /// </summary>
        [JsonProperty("spacing")]
        public long Spacing { get; set; }

        /// <summary>
        /// An array of user-defined tags to organize the Tilesets
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// Optional Enum definition UID used for this tileset meta-data
        /// </summary>
        [JsonProperty("tagsSourceEnumUid")]
        public long? TagsSourceEnumUid { get; set; }

        [JsonProperty("tileGridSize")]
        public long TileGridSize { get; set; }

        /// <summary>
        /// Unique Intidentifier
        /// </summary>
        [JsonProperty("uid")]
        public long Uid { get; set; }
    }

    /// <summary>
    /// In a tileset definition, user defined meta-data of a tile.
    /// </summary>
    public partial class TileCustomMetadata
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("tileId")]
        public long TileId { get; set; }
    }

    /// <summary>
    /// In a tileset definition, enum based tag infos
    /// </summary>
    public partial class EnumTagValue
    {
        [JsonProperty("enumValueId")]
        public string EnumValueId { get; set; }

        [JsonProperty("tileIds")]
        public long[] TileIds { get; set; }
    }

    /// <summary>
    /// This object is not actually used by LDtk. It ONLY exists to force explicit references to
    /// all types, to make sure QuickType finds them and integrate all of them. Otherwise,
    /// Quicktype will drop types that are not explicitely used.
    /// </summary>
    public partial class ForcedRefs
    {
        [JsonProperty("AutoLayerRuleGroup", NullValueHandling = NullValueHandling.Ignore)]
        public AutoLayerRuleGroup AutoLayerRuleGroup { get; set; }

        [JsonProperty("AutoRuleDef", NullValueHandling = NullValueHandling.Ignore)]
        public AutoLayerRuleDefinition AutoRuleDef { get; set; }

        [JsonProperty("Definitions", NullValueHandling = NullValueHandling.Ignore)]
        public Definitions Definitions { get; set; }

        [JsonProperty("EntityDef", NullValueHandling = NullValueHandling.Ignore)]
        public EntityDefinition EntityDef { get; set; }

        [JsonProperty("EntityInstance", NullValueHandling = NullValueHandling.Ignore)]
        public EntityInstance EntityInstance { get; set; }

        [JsonProperty("EntityReferenceInfos", NullValueHandling = NullValueHandling.Ignore)]
        public FieldInstanceEntityReference EntityReferenceInfos { get; set; }

        [JsonProperty("EnumDef", NullValueHandling = NullValueHandling.Ignore)]
        public EnumDefinition EnumDef { get; set; }

        [JsonProperty("EnumDefValues", NullValueHandling = NullValueHandling.Ignore)]
        public EnumValueDefinition EnumDefValues { get; set; }

        [JsonProperty("EnumTagValue", NullValueHandling = NullValueHandling.Ignore)]
        public EnumTagValue EnumTagValue { get; set; }

        [JsonProperty("FieldDef", NullValueHandling = NullValueHandling.Ignore)]
        public FieldDefinition FieldDef { get; set; }

        [JsonProperty("FieldInstance", NullValueHandling = NullValueHandling.Ignore)]
        public FieldInstance FieldInstance { get; set; }

        [JsonProperty("GridPoint", NullValueHandling = NullValueHandling.Ignore)]
        public FieldInstanceGridPoint GridPoint { get; set; }

        [JsonProperty("IntGridValueDef", NullValueHandling = NullValueHandling.Ignore)]
        public IntGridValueDefinition IntGridValueDef { get; set; }

        [JsonProperty("IntGridValueInstance", NullValueHandling = NullValueHandling.Ignore)]
        public IntGridValueInstance IntGridValueInstance { get; set; }

        [JsonProperty("LayerDef", NullValueHandling = NullValueHandling.Ignore)]
        public LayerDefinition LayerDef { get; set; }

        [JsonProperty("LayerInstance", NullValueHandling = NullValueHandling.Ignore)]
        public LayerInstance LayerInstance { get; set; }

        [JsonProperty("Level", NullValueHandling = NullValueHandling.Ignore)]
        public Level Level { get; set; }

        [JsonProperty("LevelBgPosInfos", NullValueHandling = NullValueHandling.Ignore)]
        public LevelBackgroundPosition LevelBgPosInfos { get; set; }

        [JsonProperty("NeighbourLevel", NullValueHandling = NullValueHandling.Ignore)]
        public NeighbourLevel NeighbourLevel { get; set; }

        [JsonProperty("Tile", NullValueHandling = NullValueHandling.Ignore)]
        public TileInstance Tile { get; set; }

        [JsonProperty("TileCustomMetadata", NullValueHandling = NullValueHandling.Ignore)]
        public TileCustomMetadata TileCustomMetadata { get; set; }

        [JsonProperty("TilesetDef", NullValueHandling = NullValueHandling.Ignore)]
        public TilesetDefinition TilesetDef { get; set; }

        [JsonProperty("TilesetRect", NullValueHandling = NullValueHandling.Ignore)]
        public TilesetRectangle TilesetRect { get; set; }

        [JsonProperty("World", NullValueHandling = NullValueHandling.Ignore)]
        public World World { get; set; }
    }

    public partial class EntityInstance
    {
        /// <summary>
        /// Grid-based coordinates (`[x,y]` format)
        /// </summary>
        [JsonProperty("__grid")]
        public long[] Grid { get; set; }

        /// <summary>
        /// Entity definition identifier
        /// </summary>
        [JsonProperty("__identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Pivot coordinates  (`[x,y]` format, values are from 0 to 1) of the Entity
        /// </summary>
        [JsonProperty("__pivot")]
        public double[] Pivot { get; set; }

        /// <summary>
        /// The entity "smart" color, guessed from either Entity definition, or one its field
        /// instances.
        /// </summary>
        [JsonProperty("__smartColor")]
        public string SmartColor { get; set; }

        /// <summary>
        /// Array of tags defined in this Entity definition
        /// </summary>
        [JsonProperty("__tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// Optional TilesetRect used to display this entity (it could either be the default Entity
        /// tile, or some tile provided by a field value, like an Enum).
        /// </summary>
        [JsonProperty("__tile")]
        public TilesetRectangle Tile { get; set; }

        /// <summary>
        /// Reference of the **Entity definition** UID
        /// </summary>
        [JsonProperty("defUid")]
        public long DefUid { get; set; }

        /// <summary>
        /// An array of all custom fields and their values.
        /// </summary>
        [JsonProperty("fieldInstances")]
        public FieldInstance[] FieldInstances { get; set; }

        /// <summary>
        /// Entity height in pixels. For non-resizable entities, it will be the same as Entity
        /// definition.
        /// </summary>
        [JsonProperty("height")]
        public long Height { get; set; }

        /// <summary>
        /// Unique instance identifier
        /// </summary>
        [JsonProperty("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// Pixel coordinates (`[x,y]` format) in current level coordinate space. Don't forget
        /// optional layer offsets, if they exist!
        /// </summary>
        [JsonProperty("px")]
        public long[] Px { get; set; }

        /// <summary>
        /// Entity width in pixels. For non-resizable entities, it will be the same as Entity
        /// definition.
        /// </summary>
        [JsonProperty("width")]
        public long Width { get; set; }
    }

    public partial class FieldInstance
    {
        /// <summary>
        /// Field definition identifier
        /// </summary>
        [JsonProperty("__identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Optional TilesetRect used to display this field (this can be the field own Tile, or some
        /// other Tile guessed from the value, like an Enum).
        /// </summary>
        [JsonProperty("__tile")]
        public TilesetRectangle Tile { get; set; }

        /// <summary>
        /// Type of the field, such as `Int`, `Float`, `String`, `Enum(my_enum_name)`, `Bool`,
        /// etc.<br/>  NOTE: if you enable the advanced option **Use Multilines type**, you will have
        /// "*Multilines*" instead of "*String*" when relevant.
        /// </summary>
        [JsonProperty("__type")]
        public string Type { get; set; }

        /// <summary>
        /// Actual value of the field instance. The value type varies, depending on `__type`:<br/>
        /// - For **classic types** (ie. Integer, Float, Boolean, String, Text and FilePath), you
        /// just get the actual value with the expected type.<br/>   - For **Color**, the value is an
        /// hexadecimal string using "#rrggbb" format.<br/>   - For **Enum**, the value is a String
        /// representing the selected enum value.<br/>   - For **Point**, the value is a
        /// [GridPoint](#ldtk-GridPoint) object.<br/>   - For **Tile**, the value is a
        /// [TilesetRect](#ldtk-TilesetRect) object.<br/>   - For **EntityRef**, the value is an
        /// [EntityReferenceInfos](#ldtk-EntityReferenceInfos) object.<br/><br/>  If the field is an
        /// array, then this `__value` will also be a JSON array.
        /// </summary>
        [JsonProperty("__value")]
        public dynamic Value { get; set; }

        /// <summary>
        /// Reference of the **Field definition** UID
        /// </summary>
        [JsonProperty("defUid")]
        public long DefUid { get; set; }

        /// <summary>
        /// Editor internal raw values
        /// </summary>
        [JsonProperty("realEditorValues")]
        public dynamic[] RealEditorValues { get; set; }
    }

    /// <summary>
    /// This object is used in Field Instances to describe an EntityRef value.
    /// </summary>
    public partial class FieldInstanceEntityReference
    {
        /// <summary>
        /// IID of the refered EntityInstance
        /// </summary>
        [JsonProperty("entityIid")]
        public string EntityIid { get; set; }

        /// <summary>
        /// IID of the LayerInstance containing the refered EntityInstance
        /// </summary>
        [JsonProperty("layerIid")]
        public string LayerIid { get; set; }

        /// <summary>
        /// IID of the Level containing the refered EntityInstance
        /// </summary>
        [JsonProperty("levelIid")]
        public string LevelIid { get; set; }

        /// <summary>
        /// IID of the World containing the refered EntityInstance
        /// </summary>
        [JsonProperty("worldIid")]
        public string WorldIid { get; set; }
    }

    /// <summary>
    /// This object is just a grid-based coordinate used in Field values.
    /// </summary>
    public partial class FieldInstanceGridPoint
    {
        /// <summary>
        /// X grid-based coordinate
        /// </summary>
        [JsonProperty("cx")]
        public long Cx { get; set; }

        /// <summary>
        /// Y grid-based coordinate
        /// </summary>
        [JsonProperty("cy")]
        public long Cy { get; set; }
    }

    /// <summary>
    /// IntGrid value instance
    /// </summary>
    public partial class IntGridValueInstance
    {
        /// <summary>
        /// Coordinate ID in the layer grid
        /// </summary>
        [JsonProperty("coordId")]
        public long CoordId { get; set; }

        /// <summary>
        /// IntGrid value
        /// </summary>
        [JsonProperty("v")]
        public long V { get; set; }
    }

    public partial class LayerInstance
    {
        /// <summary>
        /// Grid-based height
        /// </summary>
        [JsonProperty("__cHei")]
        public long CHei { get; set; }

        /// <summary>
        /// Grid-based width
        /// </summary>
        [JsonProperty("__cWid")]
        public long CWid { get; set; }

        /// <summary>
        /// Grid size
        /// </summary>
        [JsonProperty("__gridSize")]
        public long GridSize { get; set; }

        /// <summary>
        /// Layer definition identifier
        /// </summary>
        [JsonProperty("__identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Layer opacity as Float [0-1]
        /// </summary>
        [JsonProperty("__opacity")]
        public double Opacity { get; set; }

        /// <summary>
        /// Total layer X pixel offset, including both instance and definition offsets.
        /// </summary>
        [JsonProperty("__pxTotalOffsetX")]
        public long PxTotalOffsetX { get; set; }

        /// <summary>
        /// Total layer Y pixel offset, including both instance and definition offsets.
        /// </summary>
        [JsonProperty("__pxTotalOffsetY")]
        public long PxTotalOffsetY { get; set; }

        /// <summary>
        /// The definition UID of corresponding Tileset, if any.
        /// </summary>
        [JsonProperty("__tilesetDefUid")]
        public long? TilesetDefUid { get; set; }

        /// <summary>
        /// The relative path to corresponding Tileset, if any.
        /// </summary>
        [JsonProperty("__tilesetRelPath")]
        public string TilesetRelPath { get; set; }

        /// <summary>
        /// Layer type (possible values: IntGrid, Entities, Tiles or AutoLayer)
        /// </summary>
        [JsonProperty("__type")]
        public string Type { get; set; }

        /// <summary>
        /// An array containing all tiles generated by Auto-layer rules. The array is already sorted
        /// in display order (ie. 1st tile is beneath 2nd, which is beneath 3rd etc.).<br/><br/>
        /// Note: if multiple tiles are stacked in the same cell as the result of different rules,
        /// all tiles behind opaque ones will be discarded.
        /// </summary>
        [JsonProperty("autoLayerTiles")]
        public TileInstance[] AutoLayerTiles { get; set; }

        [JsonProperty("entityInstances")]
        public EntityInstance[] EntityInstances { get; set; }

        [JsonProperty("gridTiles")]
        public TileInstance[] GridTiles { get; set; }

        /// <summary>
        /// Unique layer instance identifier
        /// </summary>
        [JsonProperty("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 1.0.0  Replaced
        /// by: `intGridCsv`
        /// </summary>
        [JsonProperty("intGrid")]
        public IntGridValueInstance[] IntGrid { get; set; }

        /// <summary>
        /// A list of all values in the IntGrid layer, stored in CSV format (Comma Separated
        /// Values).<br/>  Order is from left to right, and top to bottom (ie. first row from left to
        /// right, followed by second row, etc).<br/>  `0` means "empty cell" and IntGrid values
        /// start at 1.<br/>  The array size is `__cWid` x `__cHei` cells.
        /// </summary>
        [JsonProperty("intGridCsv")]
        public long[] IntGridCsv { get; set; }

        /// <summary>
        /// Reference the Layer definition UID
        /// </summary>
        [JsonProperty("layerDefUid")]
        public long LayerDefUid { get; set; }

        /// <summary>
        /// Reference to the UID of the level containing this layer instance
        /// </summary>
        [JsonProperty("levelId")]
        public long LevelId { get; set; }

        /// <summary>
        /// An Array containing the UIDs of optional rules that were enabled in this specific layer
        /// instance.
        /// </summary>
        [JsonProperty("optionalRules")]
        public long[] OptionalRules { get; set; }

        /// <summary>
        /// This layer can use another tileset by overriding the tileset UID here.
        /// </summary>
        [JsonProperty("overrideTilesetUid")]
        public long? OverrideTilesetUid { get; set; }

        /// <summary>
        /// X offset in pixels to render this layer, usually 0 (IMPORTANT: this should be added to
        /// the `LayerDef` optional offset, see `__pxTotalOffsetX`)
        /// </summary>
        [JsonProperty("pxOffsetX")]
        public long PxOffsetX { get; set; }

        /// <summary>
        /// Y offset in pixels to render this layer, usually 0 (IMPORTANT: this should be added to
        /// the `LayerDef` optional offset, see `__pxTotalOffsetY`)
        /// </summary>
        [JsonProperty("pxOffsetY")]
        public long PxOffsetY { get; set; }

        /// <summary>
        /// Random seed used for Auto-Layers rendering
        /// </summary>
        [JsonProperty("seed")]
        public long Seed { get; set; }

        /// <summary>
        /// Layer instance visibility
        /// </summary>
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    /// <summary>
    /// This structure represents a single tile from a given Tileset.
    /// </summary>
    public partial class TileInstance
    {
        /// <summary>
        /// Internal data used by the editor.<br/>  For auto-layer tiles: `[ruleId, coordId]`.<br/>
        /// For tile-layer tiles: `[coordId]`.
        /// </summary>
        [JsonProperty("d")]
        public long[] D { get; set; }

        /// <summary>
        /// "Flip bits", a 2-bits integer to represent the mirror transformations of the tile.<br/>
        /// - Bit 0 = X flip<br/>   - Bit 1 = Y flip<br/>   Examples: f=0 (no flip), f=1 (X flip
        /// only), f=2 (Y flip only), f=3 (both flips)
        /// </summary>
        [JsonProperty("f")]
        public long F { get; set; }

        /// <summary>
        /// Pixel coordinates of the tile in the **layer** (`[x,y]` format). Don't forget optional
        /// layer offsets, if they exist!
        /// </summary>
        [JsonProperty("px")]
        public long[] Px { get; set; }

        /// <summary>
        /// Pixel coordinates of the tile in the **tileset** (`[x,y]` format)
        /// </summary>
        [JsonProperty("src")]
        public long[] Src { get; set; }

        /// <summary>
        /// The *Tile ID* in the corresponding tileset.
        /// </summary>
        [JsonProperty("t")]
        public long T { get; set; }
    }

    /// <summary>
    /// This section contains all the level data. It can be found in 2 distinct forms, depending
    /// on Project current settings:  - If "*Separate level files*" is **disabled** (default):
    /// full level data is *embedded* inside the main Project JSON file, - If "*Separate level
    /// files*" is **enabled**: level data is stored in *separate* standalone `.ldtkl` files (one
    /// per level). In this case, the main Project JSON file will still contain most level data,
    /// except heavy sections, like the `layerInstances` array (which will be null). The
    /// `externalRelPath` string points to the `ldtkl` file.  A `ldtkl` file is just a JSON file
    /// containing exactly what is described below.
    /// </summary>
    public partial class Level
    {
        /// <summary>
        /// Background color of the level (same as `bgColor`, except the default value is
        /// automatically used here if its value is `null`)
        /// </summary>
        [JsonProperty("__bgColor")]
        public string BgColor { get; set; }

        /// <summary>
        /// Position informations of the background image, if there is one.
        /// </summary>
        [JsonProperty("__bgPos")]
        public LevelBackgroundPosition BgPos { get; set; }

        /// <summary>
        /// An array listing all other levels touching this one on the world map.<br/>  Only relevant
        /// for world layouts where level spatial positioning is manual (ie. GridVania, Free). For
        /// Horizontal and Vertical layouts, this array is always empty.
        /// </summary>
        [JsonProperty("__neighbours")]
        public NeighbourLevel[] Neighbours { get; set; }

        /// <summary>
        /// The "guessed" color for this level in the editor, decided using either the background
        /// color or an existing custom field.
        /// </summary>
        [JsonProperty("__smartColor")]
        public string SmartColor { get; set; }

        /// <summary>
        /// Background color of the level. If `null`, the project `defaultLevelBgColor` should be
        /// used.
        /// </summary>
        [JsonProperty("bgColor")]
        public string LevelBgColor { get; set; }

        /// <summary>
        /// Background image X pivot (0-1)
        /// </summary>
        [JsonProperty("bgPivotX")]
        public double BgPivotX { get; set; }

        /// <summary>
        /// Background image Y pivot (0-1)
        /// </summary>
        [JsonProperty("bgPivotY")]
        public double BgPivotY { get; set; }

        /// <summary>
        /// An enum defining the way the background image (if any) is positioned on the level. See
        /// `__bgPos` for resulting position info. Possible values: &lt;`null`&gt;, `Unscaled`,
        /// `Contain`, `Cover`, `CoverDirty`
        /// </summary>
        [JsonProperty("bgPos")]
        public BgPos? LevelBgPos { get; set; }

        /// <summary>
        /// The *optional* relative path to the level background image.
        /// </summary>
        [JsonProperty("bgRelPath")]
        public string BgRelPath { get; set; }

        /// <summary>
        /// This value is not null if the project option "*Save levels separately*" is enabled. In
        /// this case, this **relative** path points to the level Json file.
        /// </summary>
        [JsonProperty("externalRelPath")]
        public string ExternalRelPath { get; set; }

        /// <summary>
        /// An array containing this level custom field values.
        /// </summary>
        [JsonProperty("fieldInstances")]
        public FieldInstance[] FieldInstances { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Unique instance identifier
        /// </summary>
        [JsonProperty("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// An array containing all Layer instances. **IMPORTANT**: if the project option "*Save
        /// levels separately*" is enabled, this field will be `null`.<br/>  This array is **sorted
        /// in display order**: the 1st layer is the top-most and the last is behind.
        /// </summary>
        [JsonProperty("layerInstances")]
        public LayerInstance[] LayerInstances { get; set; }

        /// <summary>
        /// Height of the level in pixels
        /// </summary>
        [JsonProperty("pxHei")]
        public long PxHei { get; set; }

        /// <summary>
        /// Width of the level in pixels
        /// </summary>
        [JsonProperty("pxWid")]
        public long PxWid { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonProperty("uid")]
        public long Uid { get; set; }

        /// <summary>
        /// If TRUE, the level identifier will always automatically use the naming pattern as defined
        /// in `Project.levelNamePattern`. Becomes FALSE if the identifier is manually modified by
        /// user.
        /// </summary>
        [JsonProperty("useAutoIdentifier")]
        public bool UseAutoIdentifier { get; set; }

        /// <summary>
        /// Index that represents the "depth" of the level in the world. Default is 0, greater means
        /// "above", lower means "below".<br/>  This value is mostly used for display only and is
        /// intended to make stacking of levels easier to manage.
        /// </summary>
        [JsonProperty("worldDepth")]
        public long WorldDepth { get; set; }

        /// <summary>
        /// World X coordinate in pixels.<br/>  Only relevant for world layouts where level spatial
        /// positioning is manual (ie. GridVania, Free). For Horizontal and Vertical layouts, the
        /// value is always -1 here.
        /// </summary>
        [JsonProperty("worldX")]
        public long WorldX { get; set; }

        /// <summary>
        /// World Y coordinate in pixels.<br/>  Only relevant for world layouts where level spatial
        /// positioning is manual (ie. GridVania, Free). For Horizontal and Vertical layouts, the
        /// value is always -1 here.
        /// </summary>
        [JsonProperty("worldY")]
        public long WorldY { get; set; }
    }

    /// <summary>
    /// Level background image position info
    /// </summary>
    public partial class LevelBackgroundPosition
    {
        /// <summary>
        /// An array of 4 float values describing the cropped sub-rectangle of the displayed
        /// background image. This cropping happens when original is larger than the level bounds.
        /// Array format: `[ cropX, cropY, cropWidth, cropHeight ]`
        /// </summary>
        [JsonProperty("cropRect")]
        public double[] CropRect { get; set; }

        /// <summary>
        /// An array containing the `[scaleX,scaleY]` values of the **cropped** background image,
        /// depending on `bgPos` option.
        /// </summary>
        [JsonProperty("scale")]
        public double[] Scale { get; set; }

        /// <summary>
        /// An array containing the `[x,y]` pixel coordinates of the top-left corner of the
        /// **cropped** background image, depending on `bgPos` option.
        /// </summary>
        [JsonProperty("topLeftPx")]
        public long[] TopLeftPx { get; set; }
    }

    /// <summary>
    /// Nearby level info
    /// </summary>
    public partial class NeighbourLevel
    {
        /// <summary>
        /// A single lowercase character tipping on the level location (`n`orth, `s`outh, `w`est,
        /// `e`ast).
        /// </summary>
        [JsonProperty("dir")]
        public string Dir { get; set; }

        /// <summary>
        /// Neighbour Instance Identifier
        /// </summary>
        [JsonProperty("levelIid")]
        public string LevelIid { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value will be *removed* completely on version 1.2.0+
        /// Replaced by: `levelIid`
        /// </summary>
        [JsonProperty("levelUid", NullValueHandling = NullValueHandling.Ignore)]
        public long? LevelUid { get; set; }
    }

    /// <summary>
    /// **IMPORTANT**: this type is not used *yet* in current LDtk version. It's only presented
    /// here as a preview of a planned feature.  A World contains multiple levels, and it has its
    /// own layout settings.
    /// </summary>
    public partial class World
    {
        /// <summary>
        /// Default new level height
        /// </summary>
        [JsonProperty("defaultLevelHeight")]
        public long DefaultLevelHeight { get; set; }

        /// <summary>
        /// Default new level width
        /// </summary>
        [JsonProperty("defaultLevelWidth")]
        public long DefaultLevelWidth { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Unique instance identifer
        /// </summary>
        [JsonProperty("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// All levels from this world. The order of this array is only relevant in
        /// `LinearHorizontal` and `linearVertical` world layouts (see `worldLayout` value).
        /// Otherwise, you should refer to the `worldX`,`worldY` coordinates of each Level.
        /// </summary>
        [JsonProperty("levels")]
        public Level[] Levels { get; set; }

        /// <summary>
        /// Height of the world grid in pixels.
        /// </summary>
        [JsonProperty("worldGridHeight")]
        public long WorldGridHeight { get; set; }

        /// <summary>
        /// Width of the world grid in pixels.
        /// </summary>
        [JsonProperty("worldGridWidth")]
        public long WorldGridWidth { get; set; }

        /// <summary>
        /// An enum that describes how levels are organized in this project (ie. linearly or in a 2D
        /// space). Possible values: `Free`, `GridVania`, `LinearHorizontal`, `LinearVertical`, `null`
        /// </summary>
        [JsonProperty("worldLayout")]
        public WorldLayout? WorldLayout { get; set; }
    }

    /// <summary>
    /// Possible values: `Any`, `OnlySame`, `OnlyTags`
    /// </summary>
    public enum AllowedRefs { Any, OnlySame, OnlyTags };

    /// <summary>
    /// Possible values: `Hidden`, `ValueOnly`, `NameAndValue`, `EntityTile`, `Points`,
    /// `PointStar`, `PointPath`, `PointPathLoop`, `RadiusPx`, `RadiusGrid`,
    /// `ArrayCountWithLabel`, `ArrayCountNoLabel`, `RefLinkBetweenPivots`,
    /// `RefLinkBetweenCenters`
    /// </summary>
    public enum EditorDisplayMode { ArrayCountNoLabel, ArrayCountWithLabel, EntityTile, Hidden, NameAndValue, PointPath, PointPathLoop, PointStar, Points, RadiusGrid, RadiusPx, RefLinkBetweenCenters, RefLinkBetweenPivots, ValueOnly };

    /// <summary>
    /// Possible values: `Above`, `Center`, `Beneath`
    /// </summary>
    public enum EditorDisplayPos { Above, Beneath, Center };

    public enum TextLanguageMode { LangC, LangHaxe, LangJs, LangJson, LangLog, LangLua, LangMarkdown, LangPython, LangRuby, LangXml };

    /// <summary>
    /// Possible values: `DiscardOldOnes`, `PreventAdding`, `MoveLastOne`
    /// </summary>
    public enum LimitBehavior { DiscardOldOnes, MoveLastOne, PreventAdding };

    /// <summary>
    /// If TRUE, the maxCount is a "per world" limit, if FALSE, it's a "per level". Possible
    /// values: `PerLayer`, `PerLevel`, `PerWorld`
    /// </summary>
    public enum LimitScope { PerLayer, PerLevel, PerWorld };

    /// <summary>
    /// Possible values: `Rectangle`, `Ellipse`, `Tile`, `Cross`
    /// </summary>
    public enum RenderMode { Cross, Ellipse, Rectangle, Tile };

    /// <summary>
    /// An enum describing how the the Entity tile is rendered inside the Entity bounds. Possible
    /// values: `Cover`, `FitInside`, `Repeat`, `Stretch`, `FullSizeCropped`,
    /// `FullSizeUncropped`, `NineSlice`
    /// </summary>
    public enum TileRenderMode { Cover, FitInside, FullSizeCropped, FullSizeUncropped, NineSlice, Repeat, Stretch };

    /// <summary>
    /// Checker mode Possible values: `None`, `Horizontal`, `Vertical`
    /// </summary>
    public enum Checker { Horizontal, None, Vertical };

    /// <summary>
    /// Defines how tileIds array is used Possible values: `Single`, `Stamp`
    /// </summary>
    public enum TileMode { Single, Stamp };

    /// <summary>
    /// Type of the layer as Haxe Enum Possible values: `IntGrid`, `Entities`, `Tiles`,
    /// `AutoLayer`
    /// </summary>
    public enum TypeEnum { AutoLayer, Entities, IntGrid, Tiles };

    public enum EmbedAtlas { LdtkIcons };

    public enum Flag { DiscardPreCsvIntGrid, ExportPreCsvIntGridFormat, IgnoreBackupSuggest, MultiWorlds, PrependIndexToLevelFileNames, UseMultilinesType };

    public enum BgPos { Contain, Cover, CoverDirty, Unscaled };

    public enum WorldLayout { Free, GridVania, LinearHorizontal, LinearVertical };

    /// <summary>
    /// Naming convention for Identifiers (first-letter uppercase, full uppercase etc.) Possible
    /// values: `Capitalize`, `Uppercase`, `Lowercase`, `Free`
    /// </summary>
    public enum IdentifierStyle { Capitalize, Free, Lowercase, Uppercase };

    /// <summary>
    /// "Image export" option when saving project. Possible values: `None`, `OneImagePerLayer`,
    /// `OneImagePerLevel`, `LayersAndLevels`
    /// </summary>
    public enum ImageExportMode { LayersAndLevels, None, OneImagePerLayer, OneImagePerLevel };

    public partial class LdtkJson
    {
        public static LdtkJson FromJson(string json) => JsonConvert.DeserializeObject<LdtkJson>(json, ldtk.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LdtkJson self) => JsonConvert.SerializeObject(self, ldtk.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CheckerConverter.Singleton,
                TileModeConverter.Singleton,
                AllowedRefsConverter.Singleton,
                EditorDisplayModeConverter.Singleton,
                EditorDisplayPosConverter.Singleton,
                TextLanguageModeConverter.Singleton,
                LimitBehaviorConverter.Singleton,
                LimitScopeConverter.Singleton,
                RenderModeConverter.Singleton,
                TileRenderModeConverter.Singleton,
                TypeEnumConverter.Singleton,
                EmbedAtlasConverter.Singleton,
                BgPosConverter.Singleton,
                WorldLayoutConverter.Singleton,
                FlagConverter.Singleton,
                IdentifierStyleConverter.Singleton,
                ImageExportModeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CheckerConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Checker) || t == typeof(Checker?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Horizontal":
                    return Checker.Horizontal;
                case "None":
                    return Checker.None;
                case "Vertical":
                    return Checker.Vertical;
            }
            throw new Exception("Cannot unmarshal type Checker");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Checker)untypedValue;
            switch (value)
            {
                case Checker.Horizontal:
                    serializer.Serialize(writer, "Horizontal");
                    return;
                case Checker.None:
                    serializer.Serialize(writer, "None");
                    return;
                case Checker.Vertical:
                    serializer.Serialize(writer, "Vertical");
                    return;
            }
            throw new Exception("Cannot marshal type Checker");
        }

        public static readonly CheckerConverter Singleton = new CheckerConverter();
    }

    internal class TileModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TileMode) || t == typeof(TileMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Single":
                    return TileMode.Single;
                case "Stamp":
                    return TileMode.Stamp;
            }
            throw new Exception("Cannot unmarshal type TileMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TileMode)untypedValue;
            switch (value)
            {
                case TileMode.Single:
                    serializer.Serialize(writer, "Single");
                    return;
                case TileMode.Stamp:
                    serializer.Serialize(writer, "Stamp");
                    return;
            }
            throw new Exception("Cannot marshal type TileMode");
        }

        public static readonly TileModeConverter Singleton = new TileModeConverter();
    }

    internal class AllowedRefsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AllowedRefs) || t == typeof(AllowedRefs?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Any":
                    return AllowedRefs.Any;
                case "OnlySame":
                    return AllowedRefs.OnlySame;
                case "OnlyTags":
                    return AllowedRefs.OnlyTags;
            }
            throw new Exception("Cannot unmarshal type AllowedRefs");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AllowedRefs)untypedValue;
            switch (value)
            {
                case AllowedRefs.Any:
                    serializer.Serialize(writer, "Any");
                    return;
                case AllowedRefs.OnlySame:
                    serializer.Serialize(writer, "OnlySame");
                    return;
                case AllowedRefs.OnlyTags:
                    serializer.Serialize(writer, "OnlyTags");
                    return;
            }
            throw new Exception("Cannot marshal type AllowedRefs");
        }

        public static readonly AllowedRefsConverter Singleton = new AllowedRefsConverter();
    }

    internal class EditorDisplayModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EditorDisplayMode) || t == typeof(EditorDisplayMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ArrayCountNoLabel":
                    return EditorDisplayMode.ArrayCountNoLabel;
                case "ArrayCountWithLabel":
                    return EditorDisplayMode.ArrayCountWithLabel;
                case "EntityTile":
                    return EditorDisplayMode.EntityTile;
                case "Hidden":
                    return EditorDisplayMode.Hidden;
                case "NameAndValue":
                    return EditorDisplayMode.NameAndValue;
                case "PointPath":
                    return EditorDisplayMode.PointPath;
                case "PointPathLoop":
                    return EditorDisplayMode.PointPathLoop;
                case "PointStar":
                    return EditorDisplayMode.PointStar;
                case "Points":
                    return EditorDisplayMode.Points;
                case "RadiusGrid":
                    return EditorDisplayMode.RadiusGrid;
                case "RadiusPx":
                    return EditorDisplayMode.RadiusPx;
                case "RefLinkBetweenCenters":
                    return EditorDisplayMode.RefLinkBetweenCenters;
                case "RefLinkBetweenPivots":
                    return EditorDisplayMode.RefLinkBetweenPivots;
                case "ValueOnly":
                    return EditorDisplayMode.ValueOnly;
            }
            throw new Exception("Cannot unmarshal type EditorDisplayMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EditorDisplayMode)untypedValue;
            switch (value)
            {
                case EditorDisplayMode.ArrayCountNoLabel:
                    serializer.Serialize(writer, "ArrayCountNoLabel");
                    return;
                case EditorDisplayMode.ArrayCountWithLabel:
                    serializer.Serialize(writer, "ArrayCountWithLabel");
                    return;
                case EditorDisplayMode.EntityTile:
                    serializer.Serialize(writer, "EntityTile");
                    return;
                case EditorDisplayMode.Hidden:
                    serializer.Serialize(writer, "Hidden");
                    return;
                case EditorDisplayMode.NameAndValue:
                    serializer.Serialize(writer, "NameAndValue");
                    return;
                case EditorDisplayMode.PointPath:
                    serializer.Serialize(writer, "PointPath");
                    return;
                case EditorDisplayMode.PointPathLoop:
                    serializer.Serialize(writer, "PointPathLoop");
                    return;
                case EditorDisplayMode.PointStar:
                    serializer.Serialize(writer, "PointStar");
                    return;
                case EditorDisplayMode.Points:
                    serializer.Serialize(writer, "Points");
                    return;
                case EditorDisplayMode.RadiusGrid:
                    serializer.Serialize(writer, "RadiusGrid");
                    return;
                case EditorDisplayMode.RadiusPx:
                    serializer.Serialize(writer, "RadiusPx");
                    return;
                case EditorDisplayMode.RefLinkBetweenCenters:
                    serializer.Serialize(writer, "RefLinkBetweenCenters");
                    return;
                case EditorDisplayMode.RefLinkBetweenPivots:
                    serializer.Serialize(writer, "RefLinkBetweenPivots");
                    return;
                case EditorDisplayMode.ValueOnly:
                    serializer.Serialize(writer, "ValueOnly");
                    return;
            }
            throw new Exception("Cannot marshal type EditorDisplayMode");
        }

        public static readonly EditorDisplayModeConverter Singleton = new EditorDisplayModeConverter();
    }

    internal class EditorDisplayPosConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EditorDisplayPos) || t == typeof(EditorDisplayPos?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Above":
                    return EditorDisplayPos.Above;
                case "Beneath":
                    return EditorDisplayPos.Beneath;
                case "Center":
                    return EditorDisplayPos.Center;
            }
            throw new Exception("Cannot unmarshal type EditorDisplayPos");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EditorDisplayPos)untypedValue;
            switch (value)
            {
                case EditorDisplayPos.Above:
                    serializer.Serialize(writer, "Above");
                    return;
                case EditorDisplayPos.Beneath:
                    serializer.Serialize(writer, "Beneath");
                    return;
                case EditorDisplayPos.Center:
                    serializer.Serialize(writer, "Center");
                    return;
            }
            throw new Exception("Cannot marshal type EditorDisplayPos");
        }

        public static readonly EditorDisplayPosConverter Singleton = new EditorDisplayPosConverter();
    }

    internal class TextLanguageModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextLanguageMode) || t == typeof(TextLanguageMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "LangC":
                    return TextLanguageMode.LangC;
                case "LangHaxe":
                    return TextLanguageMode.LangHaxe;
                case "LangJS":
                    return TextLanguageMode.LangJs;
                case "LangJson":
                    return TextLanguageMode.LangJson;
                case "LangLog":
                    return TextLanguageMode.LangLog;
                case "LangLua":
                    return TextLanguageMode.LangLua;
                case "LangMarkdown":
                    return TextLanguageMode.LangMarkdown;
                case "LangPython":
                    return TextLanguageMode.LangPython;
                case "LangRuby":
                    return TextLanguageMode.LangRuby;
                case "LangXml":
                    return TextLanguageMode.LangXml;
            }
            throw new Exception("Cannot unmarshal type TextLanguageMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TextLanguageMode)untypedValue;
            switch (value)
            {
                case TextLanguageMode.LangC:
                    serializer.Serialize(writer, "LangC");
                    return;
                case TextLanguageMode.LangHaxe:
                    serializer.Serialize(writer, "LangHaxe");
                    return;
                case TextLanguageMode.LangJs:
                    serializer.Serialize(writer, "LangJS");
                    return;
                case TextLanguageMode.LangJson:
                    serializer.Serialize(writer, "LangJson");
                    return;
                case TextLanguageMode.LangLog:
                    serializer.Serialize(writer, "LangLog");
                    return;
                case TextLanguageMode.LangLua:
                    serializer.Serialize(writer, "LangLua");
                    return;
                case TextLanguageMode.LangMarkdown:
                    serializer.Serialize(writer, "LangMarkdown");
                    return;
                case TextLanguageMode.LangPython:
                    serializer.Serialize(writer, "LangPython");
                    return;
                case TextLanguageMode.LangRuby:
                    serializer.Serialize(writer, "LangRuby");
                    return;
                case TextLanguageMode.LangXml:
                    serializer.Serialize(writer, "LangXml");
                    return;
            }
            throw new Exception("Cannot marshal type TextLanguageMode");
        }

        public static readonly TextLanguageModeConverter Singleton = new TextLanguageModeConverter();
    }

    internal class LimitBehaviorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LimitBehavior) || t == typeof(LimitBehavior?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DiscardOldOnes":
                    return LimitBehavior.DiscardOldOnes;
                case "MoveLastOne":
                    return LimitBehavior.MoveLastOne;
                case "PreventAdding":
                    return LimitBehavior.PreventAdding;
            }
            throw new Exception("Cannot unmarshal type LimitBehavior");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LimitBehavior)untypedValue;
            switch (value)
            {
                case LimitBehavior.DiscardOldOnes:
                    serializer.Serialize(writer, "DiscardOldOnes");
                    return;
                case LimitBehavior.MoveLastOne:
                    serializer.Serialize(writer, "MoveLastOne");
                    return;
                case LimitBehavior.PreventAdding:
                    serializer.Serialize(writer, "PreventAdding");
                    return;
            }
            throw new Exception("Cannot marshal type LimitBehavior");
        }

        public static readonly LimitBehaviorConverter Singleton = new LimitBehaviorConverter();
    }

    internal class LimitScopeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LimitScope) || t == typeof(LimitScope?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "PerLayer":
                    return LimitScope.PerLayer;
                case "PerLevel":
                    return LimitScope.PerLevel;
                case "PerWorld":
                    return LimitScope.PerWorld;
            }
            throw new Exception("Cannot unmarshal type LimitScope");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LimitScope)untypedValue;
            switch (value)
            {
                case LimitScope.PerLayer:
                    serializer.Serialize(writer, "PerLayer");
                    return;
                case LimitScope.PerLevel:
                    serializer.Serialize(writer, "PerLevel");
                    return;
                case LimitScope.PerWorld:
                    serializer.Serialize(writer, "PerWorld");
                    return;
            }
            throw new Exception("Cannot marshal type LimitScope");
        }

        public static readonly LimitScopeConverter Singleton = new LimitScopeConverter();
    }

    internal class RenderModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RenderMode) || t == typeof(RenderMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Cross":
                    return RenderMode.Cross;
                case "Ellipse":
                    return RenderMode.Ellipse;
                case "Rectangle":
                    return RenderMode.Rectangle;
                case "Tile":
                    return RenderMode.Tile;
            }
            throw new Exception("Cannot unmarshal type RenderMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RenderMode)untypedValue;
            switch (value)
            {
                case RenderMode.Cross:
                    serializer.Serialize(writer, "Cross");
                    return;
                case RenderMode.Ellipse:
                    serializer.Serialize(writer, "Ellipse");
                    return;
                case RenderMode.Rectangle:
                    serializer.Serialize(writer, "Rectangle");
                    return;
                case RenderMode.Tile:
                    serializer.Serialize(writer, "Tile");
                    return;
            }
            throw new Exception("Cannot marshal type RenderMode");
        }

        public static readonly RenderModeConverter Singleton = new RenderModeConverter();
    }

    internal class TileRenderModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TileRenderMode) || t == typeof(TileRenderMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Cover":
                    return TileRenderMode.Cover;
                case "FitInside":
                    return TileRenderMode.FitInside;
                case "FullSizeCropped":
                    return TileRenderMode.FullSizeCropped;
                case "FullSizeUncropped":
                    return TileRenderMode.FullSizeUncropped;
                case "NineSlice":
                    return TileRenderMode.NineSlice;
                case "Repeat":
                    return TileRenderMode.Repeat;
                case "Stretch":
                    return TileRenderMode.Stretch;
            }
            throw new Exception("Cannot unmarshal type TileRenderMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TileRenderMode)untypedValue;
            switch (value)
            {
                case TileRenderMode.Cover:
                    serializer.Serialize(writer, "Cover");
                    return;
                case TileRenderMode.FitInside:
                    serializer.Serialize(writer, "FitInside");
                    return;
                case TileRenderMode.FullSizeCropped:
                    serializer.Serialize(writer, "FullSizeCropped");
                    return;
                case TileRenderMode.FullSizeUncropped:
                    serializer.Serialize(writer, "FullSizeUncropped");
                    return;
                case TileRenderMode.NineSlice:
                    serializer.Serialize(writer, "NineSlice");
                    return;
                case TileRenderMode.Repeat:
                    serializer.Serialize(writer, "Repeat");
                    return;
                case TileRenderMode.Stretch:
                    serializer.Serialize(writer, "Stretch");
                    return;
            }
            throw new Exception("Cannot marshal type TileRenderMode");
        }

        public static readonly TileRenderModeConverter Singleton = new TileRenderModeConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AutoLayer":
                    return TypeEnum.AutoLayer;
                case "Entities":
                    return TypeEnum.Entities;
                case "IntGrid":
                    return TypeEnum.IntGrid;
                case "Tiles":
                    return TypeEnum.Tiles;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.AutoLayer:
                    serializer.Serialize(writer, "AutoLayer");
                    return;
                case TypeEnum.Entities:
                    serializer.Serialize(writer, "Entities");
                    return;
                case TypeEnum.IntGrid:
                    serializer.Serialize(writer, "IntGrid");
                    return;
                case TypeEnum.Tiles:
                    serializer.Serialize(writer, "Tiles");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class EmbedAtlasConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EmbedAtlas) || t == typeof(EmbedAtlas?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "LdtkIcons")
            {
                return EmbedAtlas.LdtkIcons;
            }
            throw new Exception("Cannot unmarshal type EmbedAtlas");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EmbedAtlas)untypedValue;
            if (value == EmbedAtlas.LdtkIcons)
            {
                serializer.Serialize(writer, "LdtkIcons");
                return;
            }
            throw new Exception("Cannot marshal type EmbedAtlas");
        }

        public static readonly EmbedAtlasConverter Singleton = new EmbedAtlasConverter();
    }

    internal class BgPosConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BgPos) || t == typeof(BgPos?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Contain":
                    return BgPos.Contain;
                case "Cover":
                    return BgPos.Cover;
                case "CoverDirty":
                    return BgPos.CoverDirty;
                case "Unscaled":
                    return BgPos.Unscaled;
            }
            throw new Exception("Cannot unmarshal type BgPos");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BgPos)untypedValue;
            switch (value)
            {
                case BgPos.Contain:
                    serializer.Serialize(writer, "Contain");
                    return;
                case BgPos.Cover:
                    serializer.Serialize(writer, "Cover");
                    return;
                case BgPos.CoverDirty:
                    serializer.Serialize(writer, "CoverDirty");
                    return;
                case BgPos.Unscaled:
                    serializer.Serialize(writer, "Unscaled");
                    return;
            }
            throw new Exception("Cannot marshal type BgPos");
        }

        public static readonly BgPosConverter Singleton = new BgPosConverter();
    }

    internal class WorldLayoutConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WorldLayout) || t == typeof(WorldLayout?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Free":
                    return WorldLayout.Free;
                case "GridVania":
                    return WorldLayout.GridVania;
                case "LinearHorizontal":
                    return WorldLayout.LinearHorizontal;
                case "LinearVertical":
                    return WorldLayout.LinearVertical;
            }
            throw new Exception("Cannot unmarshal type WorldLayout");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WorldLayout)untypedValue;
            switch (value)
            {
                case WorldLayout.Free:
                    serializer.Serialize(writer, "Free");
                    return;
                case WorldLayout.GridVania:
                    serializer.Serialize(writer, "GridVania");
                    return;
                case WorldLayout.LinearHorizontal:
                    serializer.Serialize(writer, "LinearHorizontal");
                    return;
                case WorldLayout.LinearVertical:
                    serializer.Serialize(writer, "LinearVertical");
                    return;
            }
            throw new Exception("Cannot marshal type WorldLayout");
        }

        public static readonly WorldLayoutConverter Singleton = new WorldLayoutConverter();
    }

    internal class FlagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Flag) || t == typeof(Flag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DiscardPreCsvIntGrid":
                    return Flag.DiscardPreCsvIntGrid;
                case "ExportPreCsvIntGridFormat":
                    return Flag.ExportPreCsvIntGridFormat;
                case "IgnoreBackupSuggest":
                    return Flag.IgnoreBackupSuggest;
                case "MultiWorlds":
                    return Flag.MultiWorlds;
                case "PrependIndexToLevelFileNames":
                    return Flag.PrependIndexToLevelFileNames;
                case "UseMultilinesType":
                    return Flag.UseMultilinesType;
            }
            throw new Exception("Cannot unmarshal type Flag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Flag)untypedValue;
            switch (value)
            {
                case Flag.DiscardPreCsvIntGrid:
                    serializer.Serialize(writer, "DiscardPreCsvIntGrid");
                    return;
                case Flag.ExportPreCsvIntGridFormat:
                    serializer.Serialize(writer, "ExportPreCsvIntGridFormat");
                    return;
                case Flag.IgnoreBackupSuggest:
                    serializer.Serialize(writer, "IgnoreBackupSuggest");
                    return;
                case Flag.MultiWorlds:
                    serializer.Serialize(writer, "MultiWorlds");
                    return;
                case Flag.PrependIndexToLevelFileNames:
                    serializer.Serialize(writer, "PrependIndexToLevelFileNames");
                    return;
                case Flag.UseMultilinesType:
                    serializer.Serialize(writer, "UseMultilinesType");
                    return;
            }
            throw new Exception("Cannot marshal type Flag");
        }

        public static readonly FlagConverter Singleton = new FlagConverter();
    }

    internal class IdentifierStyleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IdentifierStyle) || t == typeof(IdentifierStyle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Capitalize":
                    return IdentifierStyle.Capitalize;
                case "Free":
                    return IdentifierStyle.Free;
                case "Lowercase":
                    return IdentifierStyle.Lowercase;
                case "Uppercase":
                    return IdentifierStyle.Uppercase;
            }
            throw new Exception("Cannot unmarshal type IdentifierStyle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IdentifierStyle)untypedValue;
            switch (value)
            {
                case IdentifierStyle.Capitalize:
                    serializer.Serialize(writer, "Capitalize");
                    return;
                case IdentifierStyle.Free:
                    serializer.Serialize(writer, "Free");
                    return;
                case IdentifierStyle.Lowercase:
                    serializer.Serialize(writer, "Lowercase");
                    return;
                case IdentifierStyle.Uppercase:
                    serializer.Serialize(writer, "Uppercase");
                    return;
            }
            throw new Exception("Cannot marshal type IdentifierStyle");
        }

        public static readonly IdentifierStyleConverter Singleton = new IdentifierStyleConverter();
    }

    internal class ImageExportModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImageExportMode) || t == typeof(ImageExportMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "LayersAndLevels":
                    return ImageExportMode.LayersAndLevels;
                case "None":
                    return ImageExportMode.None;
                case "OneImagePerLayer":
                    return ImageExportMode.OneImagePerLayer;
                case "OneImagePerLevel":
                    return ImageExportMode.OneImagePerLevel;
            }
            throw new Exception("Cannot unmarshal type ImageExportMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ImageExportMode)untypedValue;
            switch (value)
            {
                case ImageExportMode.LayersAndLevels:
                    serializer.Serialize(writer, "LayersAndLevels");
                    return;
                case ImageExportMode.None:
                    serializer.Serialize(writer, "None");
                    return;
                case ImageExportMode.OneImagePerLayer:
                    serializer.Serialize(writer, "OneImagePerLayer");
                    return;
                case ImageExportMode.OneImagePerLevel:
                    serializer.Serialize(writer, "OneImagePerLevel");
                    return;
            }
            throw new Exception("Cannot marshal type ImageExportMode");
        }

        public static readonly ImageExportModeConverter Singleton = new ImageExportModeConverter();
    }
}