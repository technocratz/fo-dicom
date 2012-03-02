﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dicom.IO;

namespace Dicom {
	public class DicomTransferSyntax : DicomParseable {
		private DicomTransferSyntax() {
		}

		public DicomUID UID {
			get;
			private set;
		}

		public bool IsRetired {
			get;
			private set;
		}

		public bool IsExplicitVR {
			get;
			private set;
		}

		public bool IsEncapsulated {
			get;
			private set;
		}

		public bool IsLossy {
			get;
			private set;
		}

		public string LossyCompressionMethod {
			get;
			private set;
		}

		public bool IsDeflate {
			get;
			private set;
		}

		public Endian Endian {
			get;
			private set;
		}

		public override string ToString() {
			return UID.Name;
		}

		public override bool Equals(object obj) {
			if (obj is DicomTransferSyntax)
				return ((DicomTransferSyntax)obj).UID.Equals(UID);
			if (obj is DicomUID)
				return ((DicomUID)obj).Equals(UID);
			if (obj is String)
				return UID.Equals((String)obj);
			return false;
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}

		public static bool operator ==(DicomTransferSyntax a, DicomTransferSyntax b) {
			if (((object)a == null) && ((object)b == null))
				return true;
			if (((object)a == null) || ((object)b == null))
				return false;
			return a.UID == b.UID;
		}
		public static bool operator !=(DicomTransferSyntax a, DicomTransferSyntax b) {
			return !(a == b);
		}

		#region Dicom Transfer Syntax
		/// <summary>Implicit VR Little Endian</summary>
		public static DicomTransferSyntax ImplicitVRLittleEndian = new DicomTransferSyntax {
			UID = DicomUID.ImplicitVRLittleEndian,
			Endian = Endian.Little
		};

		/// <summary>Explicit VR Little Endian</summary>
		public static DicomTransferSyntax ExplicitVRLittleEndian = new DicomTransferSyntax {
			UID = DicomUID.ExplicitVRLittleEndian,
			IsExplicitVR = true,
			Endian = Endian.Little
		};

		/// <summary>Explicit VR Big Endian</summary>
		public static DicomTransferSyntax ExplicitVRBigEndian = new DicomTransferSyntax {
			UID = DicomUID.ExplicitVRBigEndian,
			IsExplicitVR = true,
			Endian = Endian.Big
		};

		/// <summary>Deflated Explicit VR Little Endian</summary>
		public static DicomTransferSyntax DeflatedExplicitVRLittleEndian = new DicomTransferSyntax {
			UID = DicomUID.DeflatedExplicitVRLittleEndian,
			IsExplicitVR = true,
			IsDeflate = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG Baseline (Process 1)</summary>
		public static DicomTransferSyntax JPEGProcess1 = new DicomTransferSyntax {
			UID = DicomUID.JPEGBaselineProcess1,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Extended (Process 2 &amp; 4)</summary>
		public static DicomTransferSyntax JPEGProcess2_4 = new DicomTransferSyntax {
			UID = DicomUID.JPEGExtendedProcess2_4,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Extended (Process 3 &amp; 5) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess3_5Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGExtendedProcess3_5RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Spectral Selection, Non-Hierarchical (Process 6 &amp; 8) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess6_8Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGSpectralSelectionNonHierarchicalProcess6_8RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Spectral Selection, Non-Hierarchical (Process 7 &amp; 9) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess7_9Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGSpectralSelectionNonHierarchicalProcess7_9RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Full Progression, Non-Hierarchical (Process 10 &amp; 12) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess10_12Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGFullProgressionNonHierarchicalProcess10_12RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Full Progression, Non-Hierarchical (Process 11 &amp; 13) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess11_13Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGFullProgressionNonHierarchicalProcess11_13RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Lossless, Non-Hierarchical (Process 14)</summary>
		public static DicomTransferSyntax JPEGProcess14 = new DicomTransferSyntax {
			UID = DicomUID.JPEGLosslessNonHierarchicalProcess14,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG Lossless, Non-Hierarchical (Process 15) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess15Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGLosslessNonHierarchicalProcess15RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG Extended, Hierarchical (Process 16 &amp; 18) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess16_18Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGExtendedHierarchicalProcess16_18RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Extended, Hierarchical (Process 17 &amp; 19) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess17_19Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGExtendedHierarchicalProcess17_19RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Spectral Selection, Hierarchical (Process 20 &amp; 22) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess20_22Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGSpectralSelectionHierarchicalProcess20_22RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Spectral Selection, Hierarchical (Process 21 &amp; 23) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess21_23Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGSpectralSelectionHierarchicalProcess21_23RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Full Progression, Hierarchical (Process 24 &amp; 26) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess24_26Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGFullProgressionHierarchicalProcess24_26RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Full Progression, Hierarchical (Process 25 &amp; 27) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess25_27Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGFullProgressionHierarchicalProcess25_27RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_10918_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG Lossless, Hierarchical (Process 28) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess28Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGLosslessHierarchicalProcess28RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG Lossless, Hierarchical (Process 29) (Retired)</summary>
		public static DicomTransferSyntax JPEGProcess29Retired = new DicomTransferSyntax {
			UID = DicomUID.JPEGLosslessHierarchicalProcess29RETIRED,
			IsRetired = true,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG Lossless, Non-Hierarchical, First-Order Prediction (Process 14 [Selection Value 1])</summary>
		public static DicomTransferSyntax JPEGProcess14SV1 = new DicomTransferSyntax {
			UID = DicomUID.JPEGLosslessProcess14SV1,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG-LS Lossless Image Compression</summary>
		public static DicomTransferSyntax JPEGLSLossless = new DicomTransferSyntax {
			UID = DicomUID.JPEGLSLosslessImageCompression,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG-LS Lossy (Near-Lossless) Image Compression</summary>
		public static DicomTransferSyntax JPEGLSNearLossless = new DicomTransferSyntax {
			UID = DicomUID.JPEGLSLossyNearLosslessImageCompression,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_14495_1",
			Endian = Endian.Little
		};

		/// <summary>JPEG 2000 Lossless Image Compression</summary>
		public static DicomTransferSyntax JPEG2000Lossless = new DicomTransferSyntax {
			UID = DicomUID.JPEG2000ImageCompressionLosslessOnly,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};

		/// <summary>JPEG 2000 Lossy Image Compression</summary>
		public static DicomTransferSyntax JPEG2000Lossy = new DicomTransferSyntax {
			UID = DicomUID.JPEG2000ImageCompression,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_15444_1",
			Endian = Endian.Little
		};

		/// <summary>MPEG2 Main Profile @ Main Level</summary>
		public static DicomTransferSyntax MPEG2 = new DicomTransferSyntax {
			UID = DicomUID.MPEG2MainProfileMainLevel,
			IsExplicitVR = true,
			IsEncapsulated = true,
			IsLossy = true,
			LossyCompressionMethod = "ISO_13818_2",
			Endian = Endian.Little
		};

		/// <summary>RLE Lossless</summary>
		public static DicomTransferSyntax RLELossless = new DicomTransferSyntax {
			UID = DicomUID.RLELossless,
			IsExplicitVR = true,
			IsEncapsulated = true,
			Endian = Endian.Little
		};
		#endregion

		#region Static Methods
		private static IDictionary<DicomUID, DicomTransferSyntax> Entries = new Dictionary<DicomUID, DicomTransferSyntax>();

		static DicomTransferSyntax() {
			#region Load Transfer Syntax List
			Entries.Add(DicomTransferSyntax.ImplicitVRLittleEndian.UID, DicomTransferSyntax.ImplicitVRLittleEndian);
			Entries.Add(DicomTransferSyntax.ExplicitVRLittleEndian.UID, DicomTransferSyntax.ExplicitVRLittleEndian);
			Entries.Add(DicomTransferSyntax.ExplicitVRBigEndian.UID, DicomTransferSyntax.ExplicitVRBigEndian);
			Entries.Add(DicomTransferSyntax.DeflatedExplicitVRLittleEndian.UID, DicomTransferSyntax.DeflatedExplicitVRLittleEndian);
			Entries.Add(DicomTransferSyntax.JPEGProcess1.UID, DicomTransferSyntax.JPEGProcess1);
			Entries.Add(DicomTransferSyntax.JPEGProcess2_4.UID, DicomTransferSyntax.JPEGProcess2_4);
			Entries.Add(DicomTransferSyntax.JPEGProcess3_5Retired.UID, DicomTransferSyntax.JPEGProcess3_5Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess6_8Retired.UID, DicomTransferSyntax.JPEGProcess6_8Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess7_9Retired.UID, DicomTransferSyntax.JPEGProcess7_9Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess10_12Retired.UID, DicomTransferSyntax.JPEGProcess10_12Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess11_13Retired.UID, DicomTransferSyntax.JPEGProcess11_13Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess14.UID, DicomTransferSyntax.JPEGProcess14);
			Entries.Add(DicomTransferSyntax.JPEGProcess15Retired.UID, DicomTransferSyntax.JPEGProcess15Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess16_18Retired.UID, DicomTransferSyntax.JPEGProcess16_18Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess17_19Retired.UID, DicomTransferSyntax.JPEGProcess17_19Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess20_22Retired.UID, DicomTransferSyntax.JPEGProcess20_22Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess21_23Retired.UID, DicomTransferSyntax.JPEGProcess21_23Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess24_26Retired.UID, DicomTransferSyntax.JPEGProcess24_26Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess25_27Retired.UID, DicomTransferSyntax.JPEGProcess25_27Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess28Retired.UID, DicomTransferSyntax.JPEGProcess28Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess29Retired.UID, DicomTransferSyntax.JPEGProcess29Retired);
			Entries.Add(DicomTransferSyntax.JPEGProcess14SV1.UID, DicomTransferSyntax.JPEGProcess14SV1);
			Entries.Add(DicomTransferSyntax.JPEGLSLossless.UID, DicomTransferSyntax.JPEGLSLossless);
			Entries.Add(DicomTransferSyntax.JPEGLSNearLossless.UID, DicomTransferSyntax.JPEGLSNearLossless);
			Entries.Add(DicomTransferSyntax.JPEG2000Lossless.UID, DicomTransferSyntax.JPEG2000Lossless);
			Entries.Add(DicomTransferSyntax.JPEG2000Lossy.UID, DicomTransferSyntax.JPEG2000Lossy);
			Entries.Add(DicomTransferSyntax.MPEG2.UID, DicomTransferSyntax.MPEG2);
			Entries.Add(DicomTransferSyntax.RLELossless.UID, DicomTransferSyntax.RLELossless);
			#endregion
		}

		public static DicomTransferSyntax Parse(string uid) {
			return Lookup(DicomUID.Parse(uid));
		}

		public static DicomTransferSyntax Lookup(DicomUID uid) {
			DicomTransferSyntax tx;
			if (Entries.TryGetValue(uid, out tx))
				return tx;
			throw new DicomDataException("Unknown transfer syntax UID: {0}", uid);
		}
		#endregion
	}
}
