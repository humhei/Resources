// ts2fable 0.0.0
module rec Protobuf
open System
open Fable.Core
open Fable.Import.JS

module Jspb = ______index
let [<Import("arith","google-protobuf")>] arith: Arith.IExports = jsNative
let [<Import("BinaryConstants","google-protobuf")>] binaryConstants: BinaryConstants.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Message: MessageStatic
    abstract ExtensionFieldInfo: ExtensionFieldInfoStatic
    abstract ExtensionFieldBinaryInfo: ExtensionFieldBinaryInfoStatic
    abstract Map: MapStatic
    abstract BinaryReader: BinaryReaderStatic
    abstract BinaryWriter: BinaryWriterStatic
    abstract BinaryEncoder: BinaryEncoderStatic
    abstract BinaryDecoder: BinaryDecoderStatic
    abstract BinaryIterator: BinaryIteratorStatic
    abstract Empty: EmptyStatic

type ByteSource =
    U4<ArrayBuffer, Uint8Array, ResizeArray<float>, string>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ByteSource =
    let ofArrayBuffer v: ByteSource = v |> U4.Case1
    let isArrayBuffer (v: ByteSource) = match v with U4.Case1 _ -> true | _ -> false
    let asArrayBuffer (v: ByteSource) = match v with U4.Case1 o -> Some o | _ -> None
    let ofUint8Array v: ByteSource = v |> U4.Case2
    let isUint8Array (v: ByteSource) = match v with U4.Case2 _ -> true | _ -> false
    let asUint8Array (v: ByteSource) = match v with U4.Case2 o -> Some o | _ -> None
    let ofFloatArray v: ByteSource = v |> U4.Case3
    let isFloatArray (v: ByteSource) = match v with U4.Case3 _ -> true | _ -> false
    let asFloatArray (v: ByteSource) = match v with U4.Case3 o -> Some o | _ -> None
    let ofString v: ByteSource = v |> U4.Case4
    let isString (v: ByteSource) = match v with U4.Case4 _ -> true | _ -> false
    let asString (v: ByteSource) = match v with U4.Case4 o -> Some o | _ -> None

type ScalarFieldType =
    U3<bool, float, string>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ScalarFieldType =
    let ofBool v: ScalarFieldType = v |> U3.Case1
    let isBool (v: ScalarFieldType) = match v with U3.Case1 _ -> true | _ -> false
    let asBool (v: ScalarFieldType) = match v with U3.Case1 o -> Some o | _ -> None
    let ofFloat v: ScalarFieldType = v |> U3.Case2
    let isFloat (v: ScalarFieldType) = match v with U3.Case2 _ -> true | _ -> false
    let asFloat (v: ScalarFieldType) = match v with U3.Case2 o -> Some o | _ -> None
    let ofString v: ScalarFieldType = v |> U3.Case3
    let isString (v: ScalarFieldType) = match v with U3.Case3 _ -> true | _ -> false
    let asString (v: ScalarFieldType) = match v with U3.Case3 o -> Some o | _ -> None

type RepeatedFieldType =
    U2<ResizeArray<ScalarFieldType>, ResizeArray<Uint8Array>>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module RepeatedFieldType =
    let ofScalarFieldTypeArray v: RepeatedFieldType = v |> U2.Case1
    let isScalarFieldTypeArray (v: RepeatedFieldType) = match v with U2.Case1 _ -> true | _ -> false
    let asScalarFieldTypeArray (v: RepeatedFieldType) = match v with U2.Case1 o -> Some o | _ -> None
    let ofUint8ArrayArray v: RepeatedFieldType = v |> U2.Case2
    let isUint8ArrayArray (v: RepeatedFieldType) = match v with U2.Case2 _ -> true | _ -> false
    let asUint8ArrayArray (v: RepeatedFieldType) = match v with U2.Case2 o -> Some o | _ -> None

type AnyFieldType =
    U3<ScalarFieldType, RepeatedFieldType, Uint8Array>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module AnyFieldType =
    let ofScalarFieldType v: AnyFieldType = v |> U3.Case1
    let isScalarFieldType (v: AnyFieldType) = match v with U3.Case1 _ -> true | _ -> false
    let asScalarFieldType (v: AnyFieldType) = match v with U3.Case1 o -> Some o | _ -> None
    let ofRepeatedFieldType v: AnyFieldType = v |> U3.Case2
    let isRepeatedFieldType (v: AnyFieldType) = match v with U3.Case2 _ -> true | _ -> false
    let asRepeatedFieldType (v: AnyFieldType) = match v with U3.Case2 o -> Some o | _ -> None
    let ofUint8Array v: AnyFieldType = v |> U3.Case3
    let isUint8Array (v: AnyFieldType) = match v with U3.Case3 _ -> true | _ -> false
    let asUint8Array (v: AnyFieldType) = match v with U3.Case3 o -> Some o | _ -> None

type FieldValue =
    U5<string, float, bool, Uint8Array, FieldValueArray> option

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module FieldValue =
    let ofStringOption v: FieldValue = v |> Option.map U5.Case1
    let ofString v: FieldValue = v |> U5.Case1 |> Some
    let isString (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case1 _ -> true | _ -> false
    let asString (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case1 o -> Some o | _ -> None
    let ofFloatOption v: FieldValue = v |> Option.map U5.Case2
    let ofFloat v: FieldValue = v |> U5.Case2 |> Some
    let isFloat (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case2 _ -> true | _ -> false
    let asFloat (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case2 o -> Some o | _ -> None
    let ofBoolOption v: FieldValue = v |> Option.map U5.Case3
    let ofBool v: FieldValue = v |> U5.Case3 |> Some
    let isBool (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case3 _ -> true | _ -> false
    let asBool (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case3 o -> Some o | _ -> None
    let ofUint8ArrayOption v: FieldValue = v |> Option.map U5.Case4
    let ofUint8Array v: FieldValue = v |> U5.Case4 |> Some
    let isUint8Array (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case4 _ -> true | _ -> false
    let asUint8Array (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case4 o -> Some o | _ -> None
    let ofFieldValueArrayOption v: FieldValue = v |> Option.map U5.Case5
    let ofFieldValueArray v: FieldValue = v |> U5.Case5 |> Some
    let isFieldValueArray (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case5 _ -> true | _ -> false
    let asFieldValueArray (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case5 o -> Some o | _ -> None

type [<AllowNullLiteral>] FieldValueArray =
    inherit Array<FieldValue>

type [<AllowNullLiteral>] Message =
    abstract getJsPbMessageId: unit -> string option
    abstract serializeBinaryExtensions: proto: Message * writer: BinaryWriter * extensions: MessageSerializeBinaryExtensionsExtensions * getExtensionFn: (ExtensionFieldInfo<'T> -> 'T) -> unit
    abstract readBinaryExtension: proto: Message * reader: BinaryReader * extensions: MessageReadBinaryExtensionExtensions * setExtensionFn: (ExtensionFieldInfo<'T> -> 'T -> unit) -> unit
    abstract toArray: unit -> Message.MessageArray
    abstract toString: unit -> string
    abstract getExtension: fieldInfo: ExtensionFieldInfo<'T> -> 'T
    abstract setExtension: fieldInfo: ExtensionFieldInfo<'T> * value: 'T -> unit
    abstract cloneMessage: unit -> Message
    abstract clone: unit -> Message
    abstract serializeBinary: unit -> Uint8Array
    abstract toObject: ?includeInstance: bool -> obj
    abstract extensions: obj with get, set
    abstract extensionsBinary: obj with get, set

type [<AllowNullLiteral>] MessageSerializeBinaryExtensionsExtensions =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> ExtensionFieldBinaryInfo<Message> with get, set

type [<AllowNullLiteral>] MessageReadBinaryExtensionExtensions =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> ExtensionFieldBinaryInfo<Message> with get, set

type [<AllowNullLiteral>] MessageStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message
    abstract initialize: msg: Message * data: Message.MessageArray * messageId: U2<string, float> * suggestedPivot: float * ?repeatedFields: ResizeArray<float> * ?oneofFields: ResizeArray<ResizeArray<float>> option -> unit
    abstract toObjectList: field: ResizeArray<'T> * toObjectFn: (bool -> 'T -> obj) * ?includeInstance: bool -> Array<obj>
    abstract toObjectExtension: msg: Message * obj: MessageStaticToObjectExtensionObj * extensions: MessageStaticToObjectExtensionExtensions * getExtensionFn: (ExtensionFieldInfo<Message> -> Message) * ?includeInstance: bool -> unit
    abstract getField: msg: Message * fieldNumber: float -> FieldValue option
    abstract getOptionalFloatingPointField: msg: Message * fieldNumber: float -> float option
    abstract getRepeatedFloatingPointField: msg: Message * fieldNumber: float -> ResizeArray<float>
    abstract bytesAsB64: bytes: Uint8Array -> string
    abstract bytesAsU8: str: string -> Uint8Array
    abstract bytesListAsB64: bytesList: ResizeArray<Uint8Array> -> ResizeArray<string>
    abstract bytesListAsU8: strList: ResizeArray<string> -> ResizeArray<Uint8Array>
    abstract getFieldWithDefault: msg: Message * fieldNumber: float * defaultValue: 'T -> 'T
    abstract getMapField: msg: Message * fieldNumber: float * noLazyCreate: bool * valueCtor: obj -> Map<obj option, obj option>
    abstract setField: msg: Message * fieldNumber: float * value: FieldValue -> unit
    abstract addToRepeatedField: msg: Message * fieldNumber: float * value: obj option * ?index: float -> unit
    abstract setOneofField: msg: Message * fieldNumber: float * oneof: ResizeArray<float> * value: FieldValue -> unit
    abstract computeOneofCase: msg: Message * oneof: ResizeArray<float> -> float
    abstract getWrapperField: msg: Message * ctor: MessageStaticGetWrapperFieldCtor * fieldNumber: float * ?required: float -> 'T
    abstract getRepeatedWrapperField: msg: Message * ctor: MessageStaticGetRepeatedWrapperFieldCtor * fieldNumber: float -> ResizeArray<'T>
    abstract setWrapperField: msg: Message * fieldNumber: float * ?value: U2<'T, Map<obj option, obj option>> -> unit
    abstract setOneofWrapperField: msg: Message * fieldNumber: float * oneof: ResizeArray<float> * value: obj option -> unit
    abstract setRepeatedWrapperField: msg: Message * fieldNumber: float * ?value: ResizeArray<'T> -> unit
    abstract addToRepeatedWrapperField: msg: Message * fieldNumber: float * value: 'T option * ctor: MessageStaticAddToRepeatedWrapperFieldCtor * ?index: float -> 'T
    abstract toMap: field: ResizeArray<obj option> * mapKeyGetterFn: (obj option -> string) * ?toObjectFn: Message.StaticToObject * ?includeInstance: bool -> unit
    abstract difference: m1: 'T * m2: 'T -> 'T
    abstract equals: m1: Message * m2: Message -> bool
    abstract compareExtensions: extension1: MessageStaticCompareExtensionsExtension1 * extension2: MessageStaticCompareExtensionsExtension2 -> bool
    abstract compareFields: field1: obj option * field2: obj option -> bool
    abstract clone: msg: 'T -> 'T
    abstract cloneMessage: msg: 'T -> 'T
    abstract copyInto: fromMessage: Message * toMessage: Message -> unit
    abstract registerMessageType: id: float * ``constructor``: obj -> unit
    abstract deserializeBinary: bytes: Uint8Array -> Message
    abstract deserializeBinaryFromReader: message: Message * reader: BinaryReader -> Message
    abstract serializeBinaryToWriter: message: Message * writer: BinaryWriter -> unit
    abstract toObject: includeInstance: bool * msg: Message -> obj

type [<AllowNullLiteral>] MessageStaticToObjectExtensionObj =
    interface end

type [<AllowNullLiteral>] MessageStaticToObjectExtensionExtensions =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> ExtensionFieldInfo<Message> with get, set

type [<AllowNullLiteral>] MessageStaticGetWrapperFieldCtor =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message

type [<AllowNullLiteral>] MessageStaticGetRepeatedWrapperFieldCtor =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message

type [<AllowNullLiteral>] MessageStaticAddToRepeatedWrapperFieldCtor =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message

type [<AllowNullLiteral>] MessageStaticCompareExtensionsExtension1 =
    interface end

type [<AllowNullLiteral>] MessageStaticCompareExtensionsExtension2 =
    interface end

module Message =

    type MessageArray =
        ResizeArray<obj option>

    type StaticToObject =
        (bool -> Message -> obj)

type [<AllowNullLiteral>] ExtensionFieldInfo<'T> =
    abstract fieldIndex: float with get, set
    abstract fieldName: float with get, set
    abstract ctor: obj with get, set
    abstract toObjectFn: Message.StaticToObject with get, set
    abstract isRepeated: float with get, set
    abstract isMessageType: unit -> bool

type [<AllowNullLiteral>] ExtensionFieldInfoStatic =
    [<Emit "new $0($1...)">] abstract Create: fieldIndex: float * fieldName: ExtensionFieldInfoStaticFieldName * ctor: obj * toObjectFn: Message.StaticToObject * isRepeated: float -> ExtensionFieldInfo<'T>

type [<AllowNullLiteral>] ExtensionFieldInfoStaticFieldName =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> float with get, set

type [<AllowNullLiteral>] ExtensionFieldBinaryInfo<'T> =
    abstract fieldInfo: ExtensionFieldInfo<'T> with get, set
    abstract binaryReaderFn: BinaryRead with get, set
    abstract binaryWriterFn: BinaryWrite with get, set
    abstract opt_binaryMessageSerializeFn: (Message -> BinaryWriter -> unit) with get, set
    abstract opt_binaryMessageDeserializeFn: (Message -> BinaryReader -> Message) with get, set
    abstract opt_isPacked: bool with get, set

type [<AllowNullLiteral>] ExtensionFieldBinaryInfoStatic =
    [<Emit "new $0($1...)">] abstract Create: fieldInfo: ExtensionFieldInfo<'T> * binaryReaderFn: BinaryRead * binaryWriterFn: BinaryWrite * opt_binaryMessageSerializeFn: (Message -> BinaryWriter -> unit) * opt_binaryMessageDeserializeFn: (Message -> BinaryReader -> Message) * opt_isPacked: bool -> ExtensionFieldBinaryInfo<'T>

type [<AllowNullLiteral>] Map<'K, 'V> =
    abstract toArray: unit -> Array<'K * 'V>
    abstract toObject: ?includeInstance: bool -> Array<'K * 'V>
    abstract toObject: includeInstance: bool * valueToObject: (bool -> 'V -> 'VO) -> Array<'K * 'VO>
    abstract getLength: unit -> float
    abstract clear: unit -> unit
    abstract del: key: 'K -> bool
    abstract getEntryList: unit -> Array<'K * 'V>
    abstract entries: unit -> Map.Iterator<'K * 'V>
    abstract keys: unit -> Map.Iterator<'K>
    abstract forEach: callback: ('V -> 'K -> unit) * ?thisArg: MapForEachThisArg -> unit
    abstract set: key: 'K * value: 'V -> Map<'K, 'V>
    abstract get: key: 'K -> 'V option
    abstract has: key: 'K -> bool

type [<AllowNullLiteral>] MapForEachThisArg =
    interface end

type [<AllowNullLiteral>] MapStatic =
    [<Emit "new $0($1...)">] abstract Create: arr: Array<'K * 'V> * ?valueCtor: MapStaticValueCtor -> Map<'K, 'V>
    abstract fromObject: entries: Array<'TK * 'TV> * valueCtor: obj option * valueFromObject: obj option -> Map<'TK, 'TV>

type [<AllowNullLiteral>] MapStaticValueCtor =
    [<Emit "new $0($1...)">] abstract Create: init: obj option -> Map<'K, 'V>

module Map =

    type [<AllowNullLiteral>] Iterator<'T> =
        abstract next: unit -> IteratorResult<'T>

    type [<AllowNullLiteral>] IteratorResult<'T> =
        abstract ``done``: bool with get, set
        abstract value: 'T with get, set

type BinaryReadReader =
    (obj option -> BinaryReader -> unit)

type BinaryRead =
    (obj option -> BinaryReadReader -> unit)

type BinaryWriteCallback =
    (obj option -> BinaryWriter -> unit)

type BinaryWrite =
    (float -> obj option -> BinaryWriteCallback -> unit)

type [<AllowNullLiteral>] BinaryReader =
    abstract alloc: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryReader
    abstract free: unit -> unit
    abstract getFieldCursor: unit -> float
    abstract getCursor: unit -> float
    abstract getBuffer: unit -> Uint8Array
    abstract getFieldNumber: unit -> float
    abstract getWireType: unit -> BinaryConstants.WireType
    abstract isEndGroup: unit -> bool
    abstract getError: unit -> bool
    abstract setBlock: ?bytes: ByteSource * ?start: float * ?length: float -> unit
    abstract reset: unit -> unit
    abstract advance: count: float -> unit
    abstract nextField: unit -> bool
    abstract unskipHeader: unit -> unit
    abstract skipMatchingFields: unit -> unit
    abstract skipVarintField: unit -> unit
    abstract skipDelimitedField: unit -> unit
    abstract skipFixed32Field: unit -> unit
    abstract skipFixed64Field: unit -> unit
    abstract skipGroup: unit -> unit
    abstract skipField: unit -> unit
    abstract registerReadCallback: callbackName: string * callback: (BinaryReader -> obj option) -> unit
    abstract runReadCallback: callbackName: string -> obj option
    abstract readAny: fieldType: BinaryConstants.FieldType -> AnyFieldType
    abstract readMessage: BinaryRead with get, set
    abstract readGroup: field: float * message: Message * reader: BinaryReadReader -> unit
    abstract getFieldDecoder: unit -> BinaryDecoder
    abstract readInt32: unit -> float
    abstract readInt32String: unit -> string
    abstract readInt64: unit -> float
    abstract readInt64String: unit -> string
    abstract readUint32: unit -> float
    abstract readUint32String: unit -> string
    abstract readUint64: unit -> float
    abstract readUint64String: unit -> string
    abstract readSint32: unit -> float
    abstract readSint64: unit -> float
    abstract readSint64String: unit -> string
    abstract readFixed32: unit -> float
    abstract readFixed64: unit -> float
    abstract readFixed64String: unit -> string
    abstract readSfixed32: unit -> float
    abstract readSfixed32String: unit -> string
    abstract readSfixed64: unit -> float
    abstract readSfixed64String: unit -> string
    abstract readFloat: unit -> float
    abstract readDouble: unit -> float
    abstract readBool: unit -> bool
    abstract readEnum: unit -> float
    abstract readString: unit -> string
    abstract readBytes: unit -> Uint8Array
    abstract readVarintHash64: unit -> string
    abstract readFixedHash64: unit -> string
    abstract readPackedInt32: unit -> ResizeArray<float>
    abstract readPackedInt32String: unit -> ResizeArray<string>
    abstract readPackedInt64: unit -> ResizeArray<float>
    abstract readPackedInt64String: unit -> ResizeArray<string>
    abstract readPackedUint32: unit -> ResizeArray<float>
    abstract readPackedUint32String: unit -> ResizeArray<string>
    abstract readPackedUint64: unit -> ResizeArray<float>
    abstract readPackedUint64String: unit -> ResizeArray<string>
    abstract readPackedSint32: unit -> ResizeArray<float>
    abstract readPackedSint64: unit -> ResizeArray<float>
    abstract readPackedSint64String: unit -> ResizeArray<string>
    abstract readPackedFixed32: unit -> ResizeArray<float>
    abstract readPackedFixed64: unit -> ResizeArray<float>
    abstract readPackedFixed64String: unit -> ResizeArray<string>
    abstract readPackedSfixed32: unit -> ResizeArray<float>
    abstract readPackedSfixed64: unit -> ResizeArray<float>
    abstract readPackedSfixed64String: unit -> ResizeArray<string>
    abstract readPackedFloat: unit -> ResizeArray<float>
    abstract readPackedDouble: unit -> ResizeArray<float>
    abstract readPackedBool: unit -> ResizeArray<bool>
    abstract readPackedEnum: unit -> ResizeArray<float>
    abstract readPackedVarintHash64: unit -> ResizeArray<string>
    abstract readPackedFixedHash64: unit -> ResizeArray<string>

type [<AllowNullLiteral>] BinaryReaderStatic =
    [<Emit "new $0($1...)">] abstract Create: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryReader
    abstract alloc: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryReader

type [<AllowNullLiteral>] BinaryWriter =
    abstract writeSerializedMessage: bytes: Uint8Array * start: float * ``end``: float -> unit
    abstract maybeWriteSerializedMessage: ?bytes: Uint8Array * ?start: float * ?``end``: float -> unit
    abstract reset: unit -> unit
    abstract getResultBuffer: unit -> Uint8Array
    abstract getResultBase64String: unit -> string
    abstract beginSubMessage: field: float -> unit
    abstract endSubMessage: field: float -> unit
    abstract writeAny: fieldType: BinaryConstants.FieldType * field: float * value: AnyFieldType -> unit
    abstract writeInt32: field: float * ?value: float -> unit
    abstract writeInt32String: field: float * ?value: string -> unit
    abstract writeInt64: field: float * ?value: float -> unit
    abstract writeInt64String: field: float * ?value: string -> unit
    abstract writeUint32: field: float * ?value: float -> unit
    abstract writeUint32String: field: float * ?value: string -> unit
    abstract writeUint64: field: float * ?value: float -> unit
    abstract writeUint64String: field: float * ?value: string -> unit
    abstract writeSint32: field: float * ?value: float -> unit
    abstract writeSint64: field: float * ?value: float -> unit
    abstract writeSint64String: field: float * ?value: string -> unit
    abstract writeFixed32: field: float * ?value: float -> unit
    abstract writeFixed64: field: float * ?value: float -> unit
    abstract writeFixed64String: field: float * ?value: string -> unit
    abstract writeSfixed32: field: float * ?value: float -> unit
    abstract writeSfixed64: field: float * ?value: float -> unit
    abstract writeSfixed64String: field: float * ?value: string -> unit
    abstract writeFloat: field: float * ?value: float -> unit
    abstract writeDouble: field: float * ?value: float -> unit
    abstract writeBool: field: float * ?value: bool -> unit
    abstract writeEnum: field: float * ?value: float -> unit
    abstract writeString: field: float * ?value: string -> unit
    abstract writeBytes: field: float * ?value: ByteSource -> unit
    abstract writeMessage: BinaryWrite with get, set
    abstract writeGroup: field: float * value: obj option * writeCallback: BinaryWriteCallback -> unit
    abstract writeFixedHash64: field: float * ?value: string -> unit
    abstract writeVarintHash64: field: float * ?value: string -> unit
    abstract writeRepeatedInt32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedInt32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedInt64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedInt64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedUint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedUint32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedUint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedUint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedSint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedFixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedFixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedFixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedSfixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSfixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSfixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedFloat: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedDouble: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedBool: field: float * ?value: ResizeArray<bool> -> unit
    abstract writeRepeatedEnum: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedString: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedBytes: field: float * ?value: ResizeArray<ByteSource> -> unit
    abstract writeRepeatedMessage: field: float * value: ResizeArray<Message> * writerCallback: BinaryWriteCallback -> unit
    abstract writeRepeatedGroup: field: float * value: ResizeArray<Message> * writerCallback: BinaryWriteCallback -> unit
    abstract writeRepeatedFixedHash64: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedVarintHash64: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedInt32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedInt32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedInt64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedInt64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedUint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedUint32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedUint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedUint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedSint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedFixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedFixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedFixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedSfixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSfixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSfixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedFloat: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedDouble: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedBool: field: float * ?value: ResizeArray<bool> -> unit
    abstract writePackedEnum: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedFixedHash64: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedVarintHash64: field: float * ?value: ResizeArray<string> -> unit

type [<AllowNullLiteral>] BinaryWriterStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BinaryWriter

type [<AllowNullLiteral>] BinaryEncoder =
    abstract length: unit -> float
    abstract ``end``: unit -> ResizeArray<float>
    abstract writeSplitVarint64: lowBits: float * highBits: float -> unit
    abstract writeSplitFixed64: lowBits: float * highBits: float -> unit
    abstract writeUnsignedVarint32: value: float -> unit
    abstract writeSignedVarint32: value: float -> unit
    abstract writeUnsignedVarint64: value: float -> unit
    abstract writeSignedVarint64: value: float -> unit
    abstract writeZigzagVarint32: value: float -> unit
    abstract writeZigzagVarint64: value: float -> unit
    abstract writeZigzagVarint64String: value: string -> unit
    abstract writeUint8: value: float -> unit
    abstract writeUint16: value: float -> unit
    abstract writeUint32: value: float -> unit
    abstract writeUint64: value: float -> unit
    abstract writeInt8: value: float -> unit
    abstract writeInt16: value: float -> unit
    abstract writeInt32: value: float -> unit
    abstract writeInt64: value: float -> unit
    abstract writeInt64String: value: string -> unit
    abstract writeFloat: value: float -> unit
    abstract writeDouble: value: float -> unit
    abstract writeBool: value: bool -> unit
    abstract writeEnum: value: float -> unit
    abstract writeBytes: bytes: Uint8Array -> unit
    abstract writeVarintHash64: hash: string -> unit
    abstract writeFixedHash64: hash: string -> unit
    abstract writeString: value: string -> float

type [<AllowNullLiteral>] BinaryEncoderStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BinaryEncoder

type [<AllowNullLiteral>] BinaryDecoder =
    abstract free: unit -> unit
    abstract clone: unit -> BinaryDecoder
    abstract clear: unit -> unit
    abstract getBuffer: unit -> Uint8Array
    abstract setBlock: data: ByteSource * ?start: float * ?length: float -> unit
    abstract getEnd: unit -> float
    abstract setEnd: ``end``: float -> unit
    abstract reset: unit -> unit
    abstract getCursor: unit -> float
    abstract setCursor: cursor: float -> unit
    abstract advance: count: float -> unit
    abstract atEnd: unit -> bool
    abstract pastEnd: unit -> bool
    abstract getError: unit -> bool
    abstract skipVarint: unit -> unit
    abstract unskipVarint: value: float -> unit
    abstract readUnsignedVarint32: unit -> float
    abstract readSignedVarint32: unit -> float
    abstract readUnsignedVarint32String: unit -> float
    abstract readSignedVarint32String: unit -> float
    abstract readZigzagVarint32: unit -> float
    abstract readUnsignedVarint64: unit -> float
    abstract readUnsignedVarint64String: unit -> float
    abstract readSignedVarint64: unit -> float
    abstract readSignedVarint64String: unit -> float
    abstract readZigzagVarint64: unit -> float
    abstract readZigzagVarint64String: unit -> float
    abstract readUint8: unit -> float
    abstract readUint16: unit -> float
    abstract readUint32: unit -> float
    abstract readUint64: unit -> float
    abstract readUint64String: unit -> string
    abstract readInt8: unit -> float
    abstract readInt16: unit -> float
    abstract readInt32: unit -> float
    abstract readInt64: unit -> float
    abstract readInt64String: unit -> string
    abstract readFloat: unit -> float
    abstract readDouble: unit -> float
    abstract readBool: unit -> bool
    abstract readEnum: unit -> float
    abstract readString: length: float -> string
    abstract readStringWithLength: unit -> string
    abstract readBytes: length: float -> Uint8Array
    abstract readVarintHash64: unit -> string
    abstract readFixedHash64: unit -> string

type [<AllowNullLiteral>] BinaryDecoderStatic =
    [<Emit "new $0($1...)">] abstract Create: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryDecoder
    abstract alloc: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryDecoder

type [<AllowNullLiteral>] BinaryIterator =
    abstract free: unit -> unit
    abstract clear: unit -> unit
    abstract get: unit -> ScalarFieldType option
    abstract atEnd: unit -> bool
    abstract next: unit -> ScalarFieldType option

type [<AllowNullLiteral>] BinaryIteratorStatic =
    [<Emit "new $0($1...)">] abstract Create: ?decoder: BinaryDecoder * ?next: (unit -> U3<float, bool, string> option) * ?elements: Array<U3<float, bool, string>> -> BinaryIterator
    abstract alloc: ?decoder: BinaryDecoder * ?next: (unit -> U3<float, bool, string> option) * ?elements: Array<U3<float, bool, string>> -> BinaryIterator

module BinaryConstants =

    type [<AllowNullLiteral>] IExports =
        abstract FieldTypeToWireType: (FieldType -> WireType)
        abstract INVALID_FIELD_NUMBER: float
        abstract FLOAT32_EPS: float
        abstract FLOAT32_MIN: float
        abstract FLOAT32_MAX: float
        abstract FLOAT64_EPS: float
        abstract FLOAT64_MIN: float
        abstract FLOAT64_MAX: float
        abstract TWO_TO_20: float
        abstract TWO_TO_23: float
        abstract TWO_TO_31: float
        abstract TWO_TO_32: float
        abstract TWO_TO_52: float
        abstract TWO_TO_63: float
        abstract TWO_TO_64: float
        abstract ZERO_HASH: string

    type [<RequireQualifiedAccess>] FieldType =
        | INVALID = -1
        | DOUBLE = 1
        | FLOAT = 2
        | INT64 = 3
        | UINT64 = 4
        | INT32 = 5
        | FIXED64 = 6
        | FIXED32 = 7
        | BOOL = 8
        | STRING = 9
        | GROUP = 10
        | MESSAGE = 11
        | BYTES = 12
        | UINT32 = 13
        | ENUM = 14
        | SFIXED32 = 15
        | SFIXED64 = 16
        | SINT32 = 17
        | SINT64 = 18
        | FHASH64 = 30
        | VHASH64 = 31

    type [<RequireQualifiedAccess>] WireType =
        | INVALID = -1
        | VARINT = 0
        | FIXED64 = 1
        | DELIMITED = 2
        | START_GROUP = 3
        | END_GROUP = 4
        | FIXED32 = 5

module Arith =

    type [<AllowNullLiteral>] IExports =
        abstract UInt64: UInt64Static
        abstract Int64: Int64Static

    type [<AllowNullLiteral>] UInt64 =
        abstract lo: float with get, set
        abstract hi: float with get, set
        abstract cmp: other: UInt64 -> float
        abstract rightShift: unit -> UInt64
        abstract leftShift: unit -> UInt64
        abstract msb: unit -> bool
        abstract lsb: unit -> bool
        abstract zero: unit -> bool
        abstract add: other: UInt64 -> UInt64
        abstract sub: other: UInt64 -> UInt64
        abstract mul: a: float -> UInt64
        abstract div: divisor: float -> UInt64 * UInt64
        abstract toString: unit -> string
        abstract clone: unit -> UInt64

    type [<AllowNullLiteral>] UInt64Static =
        [<Emit "new $0($1...)">] abstract Create: lo: float * hi: float -> UInt64
        abstract mul32x32: a: float * b: float -> UInt64
        abstract fromString: str: string -> UInt64

    type [<AllowNullLiteral>] Int64 =
        abstract lo: float with get, set
        abstract hi: float with get, set
        abstract add: other: Int64 -> Int64
        abstract sub: other: Int64 -> Int64
        abstract clone: unit -> Int64
        abstract toString: unit -> string

    type [<AllowNullLiteral>] Int64Static =
        [<Emit "new $0($1...)">] abstract Create: lo: float * hi: float -> Int64
        abstract fromString: str: string -> Int64

type [<AllowNullLiteral>] Empty =
    inherit Jspb.Message
    abstract serializeBinary: unit -> Uint8Array
    abstract toObject: ?includeInstance: bool -> Empty.AsObject
    abstract extensions: obj with get, set
    abstract extensionsBinary: obj with get, set

type [<AllowNullLiteral>] EmptyStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Empty
    abstract toObject: includeInstance: bool * msg: Empty -> Empty.AsObject
    abstract serializeBinaryToWriter: message: Empty * writer: Jspb.BinaryWriter -> unit
    abstract deserializeBinary: bytes: Uint8Array -> Empty
    abstract deserializeBinaryFromReader: message: Empty * reader: Jspb.BinaryReader -> Empty

module Empty =

    type AsObject =
        obj
module Jspb = ______index
let [<Import("arith","google-protobuf/google/protobuf/empty_pb")>] arith: Arith.IExports = jsNative
let [<Import("BinaryConstants","google-protobuf/google/protobuf/empty_pb")>] binaryConstants: BinaryConstants.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Message: MessageStatic
    abstract ExtensionFieldInfo: ExtensionFieldInfoStatic
    abstract ExtensionFieldBinaryInfo: ExtensionFieldBinaryInfoStatic
    abstract Map: MapStatic
    abstract BinaryReader: BinaryReaderStatic
    abstract BinaryWriter: BinaryWriterStatic
    abstract BinaryEncoder: BinaryEncoderStatic
    abstract BinaryDecoder: BinaryDecoderStatic
    abstract BinaryIterator: BinaryIteratorStatic
    abstract Empty: EmptyStatic

type ByteSource =
    U4<ArrayBuffer, Uint8Array, ResizeArray<float>, string>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ByteSource =
    let ofArrayBuffer v: ByteSource = v |> U4.Case1
    let isArrayBuffer (v: ByteSource) = match v with U4.Case1 _ -> true | _ -> false
    let asArrayBuffer (v: ByteSource) = match v with U4.Case1 o -> Some o | _ -> None
    let ofUint8Array v: ByteSource = v |> U4.Case2
    let isUint8Array (v: ByteSource) = match v with U4.Case2 _ -> true | _ -> false
    let asUint8Array (v: ByteSource) = match v with U4.Case2 o -> Some o | _ -> None
    let ofFloatArray v: ByteSource = v |> U4.Case3
    let isFloatArray (v: ByteSource) = match v with U4.Case3 _ -> true | _ -> false
    let asFloatArray (v: ByteSource) = match v with U4.Case3 o -> Some o | _ -> None
    let ofString v: ByteSource = v |> U4.Case4
    let isString (v: ByteSource) = match v with U4.Case4 _ -> true | _ -> false
    let asString (v: ByteSource) = match v with U4.Case4 o -> Some o | _ -> None

type ScalarFieldType =
    U3<bool, float, string>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ScalarFieldType =
    let ofBool v: ScalarFieldType = v |> U3.Case1
    let isBool (v: ScalarFieldType) = match v with U3.Case1 _ -> true | _ -> false
    let asBool (v: ScalarFieldType) = match v with U3.Case1 o -> Some o | _ -> None
    let ofFloat v: ScalarFieldType = v |> U3.Case2
    let isFloat (v: ScalarFieldType) = match v with U3.Case2 _ -> true | _ -> false
    let asFloat (v: ScalarFieldType) = match v with U3.Case2 o -> Some o | _ -> None
    let ofString v: ScalarFieldType = v |> U3.Case3
    let isString (v: ScalarFieldType) = match v with U3.Case3 _ -> true | _ -> false
    let asString (v: ScalarFieldType) = match v with U3.Case3 o -> Some o | _ -> None

type RepeatedFieldType =
    U2<ResizeArray<ScalarFieldType>, ResizeArray<Uint8Array>>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module RepeatedFieldType =
    let ofScalarFieldTypeArray v: RepeatedFieldType = v |> U2.Case1
    let isScalarFieldTypeArray (v: RepeatedFieldType) = match v with U2.Case1 _ -> true | _ -> false
    let asScalarFieldTypeArray (v: RepeatedFieldType) = match v with U2.Case1 o -> Some o | _ -> None
    let ofUint8ArrayArray v: RepeatedFieldType = v |> U2.Case2
    let isUint8ArrayArray (v: RepeatedFieldType) = match v with U2.Case2 _ -> true | _ -> false
    let asUint8ArrayArray (v: RepeatedFieldType) = match v with U2.Case2 o -> Some o | _ -> None

type AnyFieldType =
    U3<ScalarFieldType, RepeatedFieldType, Uint8Array>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module AnyFieldType =
    let ofScalarFieldType v: AnyFieldType = v |> U3.Case1
    let isScalarFieldType (v: AnyFieldType) = match v with U3.Case1 _ -> true | _ -> false
    let asScalarFieldType (v: AnyFieldType) = match v with U3.Case1 o -> Some o | _ -> None
    let ofRepeatedFieldType v: AnyFieldType = v |> U3.Case2
    let isRepeatedFieldType (v: AnyFieldType) = match v with U3.Case2 _ -> true | _ -> false
    let asRepeatedFieldType (v: AnyFieldType) = match v with U3.Case2 o -> Some o | _ -> None
    let ofUint8Array v: AnyFieldType = v |> U3.Case3
    let isUint8Array (v: AnyFieldType) = match v with U3.Case3 _ -> true | _ -> false
    let asUint8Array (v: AnyFieldType) = match v with U3.Case3 o -> Some o | _ -> None

type FieldValue =
    U5<string, float, bool, Uint8Array, FieldValueArray> option

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module FieldValue =
    let ofStringOption v: FieldValue = v |> Option.map U5.Case1
    let ofString v: FieldValue = v |> U5.Case1 |> Some
    let isString (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case1 _ -> true | _ -> false
    let asString (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case1 o -> Some o | _ -> None
    let ofFloatOption v: FieldValue = v |> Option.map U5.Case2
    let ofFloat v: FieldValue = v |> U5.Case2 |> Some
    let isFloat (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case2 _ -> true | _ -> false
    let asFloat (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case2 o -> Some o | _ -> None
    let ofBoolOption v: FieldValue = v |> Option.map U5.Case3
    let ofBool v: FieldValue = v |> U5.Case3 |> Some
    let isBool (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case3 _ -> true | _ -> false
    let asBool (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case3 o -> Some o | _ -> None
    let ofUint8ArrayOption v: FieldValue = v |> Option.map U5.Case4
    let ofUint8Array v: FieldValue = v |> U5.Case4 |> Some
    let isUint8Array (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case4 _ -> true | _ -> false
    let asUint8Array (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case4 o -> Some o | _ -> None
    let ofFieldValueArrayOption v: FieldValue = v |> Option.map U5.Case5
    let ofFieldValueArray v: FieldValue = v |> U5.Case5 |> Some
    let isFieldValueArray (v: FieldValue) = match v with None -> false | Some o -> match o with U5.Case5 _ -> true | _ -> false
    let asFieldValueArray (v: FieldValue) = match v with None -> None | Some o -> match o with U5.Case5 o -> Some o | _ -> None

type [<AllowNullLiteral>] FieldValueArray =
    inherit Array<FieldValue>

type [<AllowNullLiteral>] Message =
    abstract getJsPbMessageId: unit -> string option
    abstract serializeBinaryExtensions: proto: Message * writer: BinaryWriter * extensions: MessageSerializeBinaryExtensionsExtensions * getExtensionFn: (ExtensionFieldInfo<'T> -> 'T) -> unit
    abstract readBinaryExtension: proto: Message * reader: BinaryReader * extensions: MessageReadBinaryExtensionExtensions * setExtensionFn: (ExtensionFieldInfo<'T> -> 'T -> unit) -> unit
    abstract toArray: unit -> Message.MessageArray
    abstract toString: unit -> string
    abstract getExtension: fieldInfo: ExtensionFieldInfo<'T> -> 'T
    abstract setExtension: fieldInfo: ExtensionFieldInfo<'T> * value: 'T -> unit
    abstract cloneMessage: unit -> Message
    abstract clone: unit -> Message
    abstract serializeBinary: unit -> Uint8Array
    abstract toObject: ?includeInstance: bool -> obj
    abstract extensions: obj with get, set
    abstract extensionsBinary: obj with get, set

type [<AllowNullLiteral>] MessageSerializeBinaryExtensionsExtensions =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> ExtensionFieldBinaryInfo<Message> with get, set

type [<AllowNullLiteral>] MessageReadBinaryExtensionExtensions =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> ExtensionFieldBinaryInfo<Message> with get, set

type [<AllowNullLiteral>] MessageStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message
    abstract initialize: msg: Message * data: Message.MessageArray * messageId: U2<string, float> * suggestedPivot: float * ?repeatedFields: ResizeArray<float> * ?oneofFields: ResizeArray<ResizeArray<float>> option -> unit
    abstract toObjectList: field: ResizeArray<'T> * toObjectFn: (bool -> 'T -> obj) * ?includeInstance: bool -> Array<obj>
    abstract toObjectExtension: msg: Message * obj: MessageStaticToObjectExtensionObj * extensions: MessageStaticToObjectExtensionExtensions * getExtensionFn: (ExtensionFieldInfo<Message> -> Message) * ?includeInstance: bool -> unit
    abstract getField: msg: Message * fieldNumber: float -> FieldValue option
    abstract getOptionalFloatingPointField: msg: Message * fieldNumber: float -> float option
    abstract getRepeatedFloatingPointField: msg: Message * fieldNumber: float -> ResizeArray<float>
    abstract bytesAsB64: bytes: Uint8Array -> string
    abstract bytesAsU8: str: string -> Uint8Array
    abstract bytesListAsB64: bytesList: ResizeArray<Uint8Array> -> ResizeArray<string>
    abstract bytesListAsU8: strList: ResizeArray<string> -> ResizeArray<Uint8Array>
    abstract getFieldWithDefault: msg: Message * fieldNumber: float * defaultValue: 'T -> 'T
    abstract getMapField: msg: Message * fieldNumber: float * noLazyCreate: bool * valueCtor: obj -> Map<obj option, obj option>
    abstract setField: msg: Message * fieldNumber: float * value: FieldValue -> unit
    abstract addToRepeatedField: msg: Message * fieldNumber: float * value: obj option * ?index: float -> unit
    abstract setOneofField: msg: Message * fieldNumber: float * oneof: ResizeArray<float> * value: FieldValue -> unit
    abstract computeOneofCase: msg: Message * oneof: ResizeArray<float> -> float
    abstract getWrapperField: msg: Message * ctor: MessageStaticGetWrapperFieldCtor * fieldNumber: float * ?required: float -> 'T
    abstract getRepeatedWrapperField: msg: Message * ctor: MessageStaticGetRepeatedWrapperFieldCtor * fieldNumber: float -> ResizeArray<'T>
    abstract setWrapperField: msg: Message * fieldNumber: float * ?value: U2<'T, Map<obj option, obj option>> -> unit
    abstract setOneofWrapperField: msg: Message * fieldNumber: float * oneof: ResizeArray<float> * value: obj option -> unit
    abstract setRepeatedWrapperField: msg: Message * fieldNumber: float * ?value: ResizeArray<'T> -> unit
    abstract addToRepeatedWrapperField: msg: Message * fieldNumber: float * value: 'T option * ctor: MessageStaticAddToRepeatedWrapperFieldCtor * ?index: float -> 'T
    abstract toMap: field: ResizeArray<obj option> * mapKeyGetterFn: (obj option -> string) * ?toObjectFn: Message.StaticToObject * ?includeInstance: bool -> unit
    abstract difference: m1: 'T * m2: 'T -> 'T
    abstract equals: m1: Message * m2: Message -> bool
    abstract compareExtensions: extension1: MessageStaticCompareExtensionsExtension1 * extension2: MessageStaticCompareExtensionsExtension2 -> bool
    abstract compareFields: field1: obj option * field2: obj option -> bool
    abstract clone: msg: 'T -> 'T
    abstract cloneMessage: msg: 'T -> 'T
    abstract copyInto: fromMessage: Message * toMessage: Message -> unit
    abstract registerMessageType: id: float * ``constructor``: obj -> unit
    abstract deserializeBinary: bytes: Uint8Array -> Message
    abstract deserializeBinaryFromReader: message: Message * reader: BinaryReader -> Message
    abstract serializeBinaryToWriter: message: Message * writer: BinaryWriter -> unit
    abstract toObject: includeInstance: bool * msg: Message -> obj

type [<AllowNullLiteral>] MessageStaticToObjectExtensionObj =
    interface end

type [<AllowNullLiteral>] MessageStaticToObjectExtensionExtensions =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> ExtensionFieldInfo<Message> with get, set

type [<AllowNullLiteral>] MessageStaticGetWrapperFieldCtor =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message

type [<AllowNullLiteral>] MessageStaticGetRepeatedWrapperFieldCtor =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message

type [<AllowNullLiteral>] MessageStaticAddToRepeatedWrapperFieldCtor =
    [<Emit "new $0($1...)">] abstract Create: unit -> Message

type [<AllowNullLiteral>] MessageStaticCompareExtensionsExtension1 =
    interface end

type [<AllowNullLiteral>] MessageStaticCompareExtensionsExtension2 =
    interface end

module Message =

    type MessageArray =
        ResizeArray<obj option>

    type StaticToObject =
        (bool -> Message -> obj)

type [<AllowNullLiteral>] ExtensionFieldInfo<'T> =
    abstract fieldIndex: float with get, set
    abstract fieldName: float with get, set
    abstract ctor: obj with get, set
    abstract toObjectFn: Message.StaticToObject with get, set
    abstract isRepeated: float with get, set
    abstract isMessageType: unit -> bool

type [<AllowNullLiteral>] ExtensionFieldInfoStatic =
    [<Emit "new $0($1...)">] abstract Create: fieldIndex: float * fieldName: ExtensionFieldInfoStaticFieldName * ctor: obj * toObjectFn: Message.StaticToObject * isRepeated: float -> ExtensionFieldInfo<'T>

type [<AllowNullLiteral>] ExtensionFieldInfoStaticFieldName =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> float with get, set

type [<AllowNullLiteral>] ExtensionFieldBinaryInfo<'T> =
    abstract fieldInfo: ExtensionFieldInfo<'T> with get, set
    abstract binaryReaderFn: BinaryRead with get, set
    abstract binaryWriterFn: BinaryWrite with get, set
    abstract opt_binaryMessageSerializeFn: (Message -> BinaryWriter -> unit) with get, set
    abstract opt_binaryMessageDeserializeFn: (Message -> BinaryReader -> Message) with get, set
    abstract opt_isPacked: bool with get, set

type [<AllowNullLiteral>] ExtensionFieldBinaryInfoStatic =
    [<Emit "new $0($1...)">] abstract Create: fieldInfo: ExtensionFieldInfo<'T> * binaryReaderFn: BinaryRead * binaryWriterFn: BinaryWrite * opt_binaryMessageSerializeFn: (Message -> BinaryWriter -> unit) * opt_binaryMessageDeserializeFn: (Message -> BinaryReader -> Message) * opt_isPacked: bool -> ExtensionFieldBinaryInfo<'T>

type [<AllowNullLiteral>] Map<'K, 'V> =
    abstract toArray: unit -> Array<'K * 'V>
    abstract toObject: ?includeInstance: bool -> Array<'K * 'V>
    abstract toObject: includeInstance: bool * valueToObject: (bool -> 'V -> 'VO) -> Array<'K * 'VO>
    abstract getLength: unit -> float
    abstract clear: unit -> unit
    abstract del: key: 'K -> bool
    abstract getEntryList: unit -> Array<'K * 'V>
    abstract entries: unit -> Map.Iterator<'K * 'V>
    abstract keys: unit -> Map.Iterator<'K>
    abstract forEach: callback: ('V -> 'K -> unit) * ?thisArg: MapForEachThisArg -> unit
    abstract set: key: 'K * value: 'V -> Map<'K, 'V>
    abstract get: key: 'K -> 'V option
    abstract has: key: 'K -> bool

type [<AllowNullLiteral>] MapForEachThisArg =
    interface end

type [<AllowNullLiteral>] MapStatic =
    [<Emit "new $0($1...)">] abstract Create: arr: Array<'K * 'V> * ?valueCtor: MapStaticValueCtor -> Map<'K, 'V>
    abstract fromObject: entries: Array<'TK * 'TV> * valueCtor: obj option * valueFromObject: obj option -> Map<'TK, 'TV>

type [<AllowNullLiteral>] MapStaticValueCtor =
    [<Emit "new $0($1...)">] abstract Create: init: obj option -> Map<'K, 'V>

module Map =

    type [<AllowNullLiteral>] Iterator<'T> =
        abstract next: unit -> IteratorResult<'T>

    type [<AllowNullLiteral>] IteratorResult<'T> =
        abstract ``done``: bool with get, set
        abstract value: 'T with get, set

type BinaryReadReader =
    (obj option -> BinaryReader -> unit)

type BinaryRead =
    (obj option -> BinaryReadReader -> unit)

type BinaryWriteCallback =
    (obj option -> BinaryWriter -> unit)

type BinaryWrite =
    (float -> obj option -> BinaryWriteCallback -> unit)

type [<AllowNullLiteral>] BinaryReader =
    abstract alloc: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryReader
    abstract free: unit -> unit
    abstract getFieldCursor: unit -> float
    abstract getCursor: unit -> float
    abstract getBuffer: unit -> Uint8Array
    abstract getFieldNumber: unit -> float
    abstract getWireType: unit -> BinaryConstants.WireType
    abstract isEndGroup: unit -> bool
    abstract getError: unit -> bool
    abstract setBlock: ?bytes: ByteSource * ?start: float * ?length: float -> unit
    abstract reset: unit -> unit
    abstract advance: count: float -> unit
    abstract nextField: unit -> bool
    abstract unskipHeader: unit -> unit
    abstract skipMatchingFields: unit -> unit
    abstract skipVarintField: unit -> unit
    abstract skipDelimitedField: unit -> unit
    abstract skipFixed32Field: unit -> unit
    abstract skipFixed64Field: unit -> unit
    abstract skipGroup: unit -> unit
    abstract skipField: unit -> unit
    abstract registerReadCallback: callbackName: string * callback: (BinaryReader -> obj option) -> unit
    abstract runReadCallback: callbackName: string -> obj option
    abstract readAny: fieldType: BinaryConstants.FieldType -> AnyFieldType
    abstract readMessage: BinaryRead with get, set
    abstract readGroup: field: float * message: Message * reader: BinaryReadReader -> unit
    abstract getFieldDecoder: unit -> BinaryDecoder
    abstract readInt32: unit -> float
    abstract readInt32String: unit -> string
    abstract readInt64: unit -> float
    abstract readInt64String: unit -> string
    abstract readUint32: unit -> float
    abstract readUint32String: unit -> string
    abstract readUint64: unit -> float
    abstract readUint64String: unit -> string
    abstract readSint32: unit -> float
    abstract readSint64: unit -> float
    abstract readSint64String: unit -> string
    abstract readFixed32: unit -> float
    abstract readFixed64: unit -> float
    abstract readFixed64String: unit -> string
    abstract readSfixed32: unit -> float
    abstract readSfixed32String: unit -> string
    abstract readSfixed64: unit -> float
    abstract readSfixed64String: unit -> string
    abstract readFloat: unit -> float
    abstract readDouble: unit -> float
    abstract readBool: unit -> bool
    abstract readEnum: unit -> float
    abstract readString: unit -> string
    abstract readBytes: unit -> Uint8Array
    abstract readVarintHash64: unit -> string
    abstract readFixedHash64: unit -> string
    abstract readPackedInt32: unit -> ResizeArray<float>
    abstract readPackedInt32String: unit -> ResizeArray<string>
    abstract readPackedInt64: unit -> ResizeArray<float>
    abstract readPackedInt64String: unit -> ResizeArray<string>
    abstract readPackedUint32: unit -> ResizeArray<float>
    abstract readPackedUint32String: unit -> ResizeArray<string>
    abstract readPackedUint64: unit -> ResizeArray<float>
    abstract readPackedUint64String: unit -> ResizeArray<string>
    abstract readPackedSint32: unit -> ResizeArray<float>
    abstract readPackedSint64: unit -> ResizeArray<float>
    abstract readPackedSint64String: unit -> ResizeArray<string>
    abstract readPackedFixed32: unit -> ResizeArray<float>
    abstract readPackedFixed64: unit -> ResizeArray<float>
    abstract readPackedFixed64String: unit -> ResizeArray<string>
    abstract readPackedSfixed32: unit -> ResizeArray<float>
    abstract readPackedSfixed64: unit -> ResizeArray<float>
    abstract readPackedSfixed64String: unit -> ResizeArray<string>
    abstract readPackedFloat: unit -> ResizeArray<float>
    abstract readPackedDouble: unit -> ResizeArray<float>
    abstract readPackedBool: unit -> ResizeArray<bool>
    abstract readPackedEnum: unit -> ResizeArray<float>
    abstract readPackedVarintHash64: unit -> ResizeArray<string>
    abstract readPackedFixedHash64: unit -> ResizeArray<string>

type [<AllowNullLiteral>] BinaryReaderStatic =
    [<Emit "new $0($1...)">] abstract Create: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryReader
    abstract alloc: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryReader

type [<AllowNullLiteral>] BinaryWriter =
    abstract writeSerializedMessage: bytes: Uint8Array * start: float * ``end``: float -> unit
    abstract maybeWriteSerializedMessage: ?bytes: Uint8Array * ?start: float * ?``end``: float -> unit
    abstract reset: unit -> unit
    abstract getResultBuffer: unit -> Uint8Array
    abstract getResultBase64String: unit -> string
    abstract beginSubMessage: field: float -> unit
    abstract endSubMessage: field: float -> unit
    abstract writeAny: fieldType: BinaryConstants.FieldType * field: float * value: AnyFieldType -> unit
    abstract writeInt32: field: float * ?value: float -> unit
    abstract writeInt32String: field: float * ?value: string -> unit
    abstract writeInt64: field: float * ?value: float -> unit
    abstract writeInt64String: field: float * ?value: string -> unit
    abstract writeUint32: field: float * ?value: float -> unit
    abstract writeUint32String: field: float * ?value: string -> unit
    abstract writeUint64: field: float * ?value: float -> unit
    abstract writeUint64String: field: float * ?value: string -> unit
    abstract writeSint32: field: float * ?value: float -> unit
    abstract writeSint64: field: float * ?value: float -> unit
    abstract writeSint64String: field: float * ?value: string -> unit
    abstract writeFixed32: field: float * ?value: float -> unit
    abstract writeFixed64: field: float * ?value: float -> unit
    abstract writeFixed64String: field: float * ?value: string -> unit
    abstract writeSfixed32: field: float * ?value: float -> unit
    abstract writeSfixed64: field: float * ?value: float -> unit
    abstract writeSfixed64String: field: float * ?value: string -> unit
    abstract writeFloat: field: float * ?value: float -> unit
    abstract writeDouble: field: float * ?value: float -> unit
    abstract writeBool: field: float * ?value: bool -> unit
    abstract writeEnum: field: float * ?value: float -> unit
    abstract writeString: field: float * ?value: string -> unit
    abstract writeBytes: field: float * ?value: ByteSource -> unit
    abstract writeMessage: BinaryWrite with get, set
    abstract writeGroup: field: float * value: obj option * writeCallback: BinaryWriteCallback -> unit
    abstract writeFixedHash64: field: float * ?value: string -> unit
    abstract writeVarintHash64: field: float * ?value: string -> unit
    abstract writeRepeatedInt32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedInt32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedInt64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedInt64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedUint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedUint32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedUint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedUint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedSint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedFixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedFixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedFixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedSfixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSfixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedSfixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedFloat: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedDouble: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedBool: field: float * ?value: ResizeArray<bool> -> unit
    abstract writeRepeatedEnum: field: float * ?value: ResizeArray<float> -> unit
    abstract writeRepeatedString: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedBytes: field: float * ?value: ResizeArray<ByteSource> -> unit
    abstract writeRepeatedMessage: field: float * value: ResizeArray<Message> * writerCallback: BinaryWriteCallback -> unit
    abstract writeRepeatedGroup: field: float * value: ResizeArray<Message> * writerCallback: BinaryWriteCallback -> unit
    abstract writeRepeatedFixedHash64: field: float * ?value: ResizeArray<string> -> unit
    abstract writeRepeatedVarintHash64: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedInt32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedInt32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedInt64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedInt64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedUint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedUint32String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedUint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedUint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedSint32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSint64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSint64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedFixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedFixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedFixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedSfixed32: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSfixed64: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedSfixed64String: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedFloat: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedDouble: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedBool: field: float * ?value: ResizeArray<bool> -> unit
    abstract writePackedEnum: field: float * ?value: ResizeArray<float> -> unit
    abstract writePackedFixedHash64: field: float * ?value: ResizeArray<string> -> unit
    abstract writePackedVarintHash64: field: float * ?value: ResizeArray<string> -> unit

type [<AllowNullLiteral>] BinaryWriterStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BinaryWriter

type [<AllowNullLiteral>] BinaryEncoder =
    abstract length: unit -> float
    abstract ``end``: unit -> ResizeArray<float>
    abstract writeSplitVarint64: lowBits: float * highBits: float -> unit
    abstract writeSplitFixed64: lowBits: float * highBits: float -> unit
    abstract writeUnsignedVarint32: value: float -> unit
    abstract writeSignedVarint32: value: float -> unit
    abstract writeUnsignedVarint64: value: float -> unit
    abstract writeSignedVarint64: value: float -> unit
    abstract writeZigzagVarint32: value: float -> unit
    abstract writeZigzagVarint64: value: float -> unit
    abstract writeZigzagVarint64String: value: string -> unit
    abstract writeUint8: value: float -> unit
    abstract writeUint16: value: float -> unit
    abstract writeUint32: value: float -> unit
    abstract writeUint64: value: float -> unit
    abstract writeInt8: value: float -> unit
    abstract writeInt16: value: float -> unit
    abstract writeInt32: value: float -> unit
    abstract writeInt64: value: float -> unit
    abstract writeInt64String: value: string -> unit
    abstract writeFloat: value: float -> unit
    abstract writeDouble: value: float -> unit
    abstract writeBool: value: bool -> unit
    abstract writeEnum: value: float -> unit
    abstract writeBytes: bytes: Uint8Array -> unit
    abstract writeVarintHash64: hash: string -> unit
    abstract writeFixedHash64: hash: string -> unit
    abstract writeString: value: string -> float

type [<AllowNullLiteral>] BinaryEncoderStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BinaryEncoder

type [<AllowNullLiteral>] BinaryDecoder =
    abstract free: unit -> unit
    abstract clone: unit -> BinaryDecoder
    abstract clear: unit -> unit
    abstract getBuffer: unit -> Uint8Array
    abstract setBlock: data: ByteSource * ?start: float * ?length: float -> unit
    abstract getEnd: unit -> float
    abstract setEnd: ``end``: float -> unit
    abstract reset: unit -> unit
    abstract getCursor: unit -> float
    abstract setCursor: cursor: float -> unit
    abstract advance: count: float -> unit
    abstract atEnd: unit -> bool
    abstract pastEnd: unit -> bool
    abstract getError: unit -> bool
    abstract skipVarint: unit -> unit
    abstract unskipVarint: value: float -> unit
    abstract readUnsignedVarint32: unit -> float
    abstract readSignedVarint32: unit -> float
    abstract readUnsignedVarint32String: unit -> float
    abstract readSignedVarint32String: unit -> float
    abstract readZigzagVarint32: unit -> float
    abstract readUnsignedVarint64: unit -> float
    abstract readUnsignedVarint64String: unit -> float
    abstract readSignedVarint64: unit -> float
    abstract readSignedVarint64String: unit -> float
    abstract readZigzagVarint64: unit -> float
    abstract readZigzagVarint64String: unit -> float
    abstract readUint8: unit -> float
    abstract readUint16: unit -> float
    abstract readUint32: unit -> float
    abstract readUint64: unit -> float
    abstract readUint64String: unit -> string
    abstract readInt8: unit -> float
    abstract readInt16: unit -> float
    abstract readInt32: unit -> float
    abstract readInt64: unit -> float
    abstract readInt64String: unit -> string
    abstract readFloat: unit -> float
    abstract readDouble: unit -> float
    abstract readBool: unit -> bool
    abstract readEnum: unit -> float
    abstract readString: length: float -> string
    abstract readStringWithLength: unit -> string
    abstract readBytes: length: float -> Uint8Array
    abstract readVarintHash64: unit -> string
    abstract readFixedHash64: unit -> string

type [<AllowNullLiteral>] BinaryDecoderStatic =
    [<Emit "new $0($1...)">] abstract Create: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryDecoder
    abstract alloc: ?bytes: ByteSource * ?start: float * ?length: float -> BinaryDecoder

type [<AllowNullLiteral>] BinaryIterator =
    abstract free: unit -> unit
    abstract clear: unit -> unit
    abstract get: unit -> ScalarFieldType option
    abstract atEnd: unit -> bool
    abstract next: unit -> ScalarFieldType option

type [<AllowNullLiteral>] BinaryIteratorStatic =
    [<Emit "new $0($1...)">] abstract Create: ?decoder: BinaryDecoder * ?next: (unit -> U3<float, bool, string> option) * ?elements: Array<U3<float, bool, string>> -> BinaryIterator
    abstract alloc: ?decoder: BinaryDecoder * ?next: (unit -> U3<float, bool, string> option) * ?elements: Array<U3<float, bool, string>> -> BinaryIterator

module BinaryConstants =

    type [<AllowNullLiteral>] IExports =
        abstract FieldTypeToWireType: (FieldType -> WireType)
        abstract INVALID_FIELD_NUMBER: float
        abstract FLOAT32_EPS: float
        abstract FLOAT32_MIN: float
        abstract FLOAT32_MAX: float
        abstract FLOAT64_EPS: float
        abstract FLOAT64_MIN: float
        abstract FLOAT64_MAX: float
        abstract TWO_TO_20: float
        abstract TWO_TO_23: float
        abstract TWO_TO_31: float
        abstract TWO_TO_32: float
        abstract TWO_TO_52: float
        abstract TWO_TO_63: float
        abstract TWO_TO_64: float
        abstract ZERO_HASH: string

    type [<RequireQualifiedAccess>] FieldType =
        | INVALID = -1
        | DOUBLE = 1
        | FLOAT = 2
        | INT64 = 3
        | UINT64 = 4
        | INT32 = 5
        | FIXED64 = 6
        | FIXED32 = 7
        | BOOL = 8
        | STRING = 9
        | GROUP = 10
        | MESSAGE = 11
        | BYTES = 12
        | UINT32 = 13
        | ENUM = 14
        | SFIXED32 = 15
        | SFIXED64 = 16
        | SINT32 = 17
        | SINT64 = 18
        | FHASH64 = 30
        | VHASH64 = 31

    type [<RequireQualifiedAccess>] WireType =
        | INVALID = -1
        | VARINT = 0
        | FIXED64 = 1
        | DELIMITED = 2
        | START_GROUP = 3
        | END_GROUP = 4
        | FIXED32 = 5

module Arith =

    type [<AllowNullLiteral>] IExports =
        abstract UInt64: UInt64Static
        abstract Int64: Int64Static

    type [<AllowNullLiteral>] UInt64 =
        abstract lo: float with get, set
        abstract hi: float with get, set
        abstract cmp: other: UInt64 -> float
        abstract rightShift: unit -> UInt64
        abstract leftShift: unit -> UInt64
        abstract msb: unit -> bool
        abstract lsb: unit -> bool
        abstract zero: unit -> bool
        abstract add: other: UInt64 -> UInt64
        abstract sub: other: UInt64 -> UInt64
        abstract mul: a: float -> UInt64
        abstract div: divisor: float -> UInt64 * UInt64
        abstract toString: unit -> string
        abstract clone: unit -> UInt64

    type [<AllowNullLiteral>] UInt64Static =
        [<Emit "new $0($1...)">] abstract Create: lo: float * hi: float -> UInt64
        abstract mul32x32: a: float * b: float -> UInt64
        abstract fromString: str: string -> UInt64

    type [<AllowNullLiteral>] Int64 =
        abstract lo: float with get, set
        abstract hi: float with get, set
        abstract add: other: Int64 -> Int64
        abstract sub: other: Int64 -> Int64
        abstract clone: unit -> Int64
        abstract toString: unit -> string

    type [<AllowNullLiteral>] Int64Static =
        [<Emit "new $0($1...)">] abstract Create: lo: float * hi: float -> Int64
        abstract fromString: str: string -> Int64

type [<AllowNullLiteral>] Empty =
    inherit Jspb.Message
    abstract serializeBinary: unit -> Uint8Array
    abstract toObject: ?includeInstance: bool -> Empty.AsObject
    abstract extensions: obj with get, set
    abstract extensionsBinary: obj with get, set

type [<AllowNullLiteral>] EmptyStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Empty
    abstract toObject: includeInstance: bool * msg: Empty -> Empty.AsObject
    abstract serializeBinaryToWriter: message: Empty * writer: Jspb.BinaryWriter -> unit
    abstract deserializeBinary: bytes: Uint8Array -> Empty
    abstract deserializeBinaryFromReader: message: Empty * reader: Jspb.BinaryReader -> Empty

module Empty =

    type AsObject =
        obj