using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusUI : MonoBehaviour
{

    [SerializeField] private Slider _hpBar;
    [SerializeField] private Player _player;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        //_hpBar = GetComponent<RectTransform>().GetChild(0).GetComponent<Slider>();
        //GetComponentInChildren<Slider>();
        // �� ������Ʈ�� ������ GameObject�� ������ ������Ʈ�� �߿� �ش� Ÿ���� ã�Ƽ� ��ȯ��.
        //GetComponents<RectTransform>();


        _hpBar.minValue = 0.0f;
        _hpBar.maxValue = _player.hpMax;
        _hpBar.value = _player.hp;
        //_player.onHpChanged += RefreshHpBar;
        // �ζ��� �Լ�  : �Լ� ������带 ���̱� ���� ��� �����θ� �ش� ���ο� ���� �����ϴ� �Լ�
        // C# ������ �ζ��� �Լ� ���� : �͸��Լ� (���ٽ�)���� ������.
        // ���ٽ� : �����Ϸ��� �Ǵ��� �� �ִ� �ڵ带 ��� �����ϰ� �̸��� ������ �Լ���

        // ex) RefreshHpBar
        // 1. �ζ��� �Լ��� ���������ڰ� �ǹ� �����Ƿ� private ����
        // 2. �����Ϸ��� �븮���� ������ float �Ķ���� 1���� void ��ȯ�̹Ƿ� void �� float Ÿ�� ����
        // 3. �ζ����̹Ƿ� �̸����� �Լ� �˻��� �� �����Ƿ� �̸� ����
        // 4. ������ �����̸� �״����� �ݵ�� �Լ� ������ �Ͼ���ϹǷ� ���������� ���� �ʿ�����Ƿ� �߰�ȣ ����
        // 5. ���ٽ� ��ø� ���� => �߰�
        _player.onHpChanged += (value) => _hpBar.value = value;
    }

    private void RefreshHpBar(float value)
    {
        _hpBar.value = value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
