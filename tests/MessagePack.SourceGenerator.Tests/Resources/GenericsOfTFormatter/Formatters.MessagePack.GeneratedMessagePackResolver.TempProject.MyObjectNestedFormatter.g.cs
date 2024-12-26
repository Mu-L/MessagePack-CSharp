﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

#pragma warning disable CS8669 // We may leak nullable annotations into generated code.

using MsgPack = global::MessagePack;

namespace MessagePack {
partial class GeneratedMessagePackResolver {
internal partial class TempProject {

	internal sealed class MyObjectNestedFormatter : MsgPack::Formatters.IMessagePackFormatter<global::TempProject.MyObjectNested>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::TempProject.MyObjectNested value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			writer.WriteArrayHeader(1);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<int>>>(formatterResolver).Serialize(ref writer, value.Value, options);
		}

		public global::TempProject.MyObjectNested Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			var length = reader.ReadArrayHeader();
			var ____result = new global::TempProject.MyObjectNested();

			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 0:
						____result.Value = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<int>>>(formatterResolver).Deserialize(ref reader, options);
						break;
					default:
						reader.Skip();
						break;
				}
			}

			reader.Depth--;
			return ____result;
		}
	}
}
}
}