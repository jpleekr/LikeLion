using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
	public class GameManager
    {
        Ball m_pBall = null;
        Bar m_pBar = null;
        Black m_pBlack = null;

        public void Initialize()
        {
            if(m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }

			if (m_pBar == null)
			{
				m_pBar = new Bar();
				m_pBar.Initialize();
			}

			if (m_pBlack == null)
			{
				m_pBlack = new Black();
				m_pBlack.Init();
			}

			m_pBall.SetBar(m_pBar);
            m_pBall.SetBlack(m_pBlack);
		}

        public void Progress()
        {
            m_pBall.Progress();
            m_pBar.Progress(ref m_pBall);
        }

        public void Render()
        {
            Console.Clear();
            m_pBall.Render();
            m_pBar.Render();
			m_pBlack.DrawBlack();

		}

		public void Release()
        {
            m_pBall.Release ();
			m_pBar.Release ();
        }

    }
}
