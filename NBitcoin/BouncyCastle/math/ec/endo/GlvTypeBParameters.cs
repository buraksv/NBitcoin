namespace NBitcoin.BouncyCastle.Math.EC.Endo
{
	internal class GlvTypeBParameters
	{
		protected readonly BigInteger m_beta;
		protected readonly BigInteger m_lambda;
		protected readonly BigInteger[] m_v1, m_v2;
		protected readonly BigInteger m_g1, m_g2;
		protected readonly int m_bits;

		public GlvTypeBParameters(BigInteger beta, BigInteger lambda, BigInteger[] v1, BigInteger[] v2,
			BigInteger g1, BigInteger g2, int bits)
		{
			this.m_beta = beta;
			this.m_lambda = lambda;
			this.m_v1 = v1;
			this.m_v2 = v2;
			this.m_g1 = g1;
			this.m_g2 = g2;
			this.m_bits = bits;
		}

		public virtual BigInteger Beta => m_beta;

		public virtual BigInteger Lambda => m_lambda;

		public virtual BigInteger[] V1 => m_v1;

		public virtual BigInteger[] V2 => m_v2;

		public virtual BigInteger G1 => m_g1;

		public virtual BigInteger G2 => m_g2;

		public virtual int Bits => m_bits;
	}
}
