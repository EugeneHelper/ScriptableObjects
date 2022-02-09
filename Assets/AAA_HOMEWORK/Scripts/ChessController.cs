// using UnityEngine;
//
// namespace AAA_HOMEWORK.Scripts
// {
//     public class ChessController : MonoBehaviour
//     {
//         [SerializeField] private SoundsConfig soundsConfig;
//         [SerializeField] private AudioSource audioSource;
//
//         [SerializeField] private SoundGroupUi soundGroupUi;
//
//         private void Reset()
//         {
//             audioSource = GetComponent<AudioSource>();
//         }
//
//         private void Start()
//         {
//             var groups = soundsConfig.GetGroupsIds();
//
//             for (var i = 0; i < groups.Length; i++)
//             {
//                 var ids = soundsConfig.GetSoundsId(groups[i]);
//                 if (i == 0)
//                 {
//                     continue;
//                 }
//
//                 var group = Instantiate(soundGroupUi, soundGroupUi.transform.parent);
//                 group.Setup(groups[i], ids, PlaySound);
//             }
//
//             soundGroupUi.Setup(groups[0], soundsConfig.GetSoundsId(groups[0]), PlaySound);
//         }
//
//         private void PlaySound(string id)
//         {
//             audioSource.Stop();
//             var info = soundsConfig.GetSoundInfo(id);
//             if (info == null)
//             {
//                 return;
//             }
//
//             audioSource.clip = info.Clip;
//             audioSource.loop = info.Loop;
//             audioSource.pitch = info.Pitch;
//             audioSource.volume = info.Volume;
//       
//             audioSource.Play();
//         }
//
//     }
// }