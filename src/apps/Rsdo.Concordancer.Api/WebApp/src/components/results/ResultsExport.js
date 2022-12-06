import { useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';

import closeIcon from '../../assets/close.svg';
import exportIcon from '../../assets/export.svg';
import styles from './ResultsExport.module.scss';

const ResultsExport = (props) => {
    // Hooks
    const { t } = useTranslation();

    const allResults = props.results;
    const defaultValue = allResults < 100 ? allResults : 100;
    const maxValue = allResults > 1000 ? 1000 : allResults;

    const [numFirst, setNumFirst] = useState(defaultValue);
    const [numRandom, setNumRandom] = useState(defaultValue);
    const [type, setType] = useState('FirstRows');
    const [isValid, setIsValid] = useState(true);

    useEffect(() => {
        let value = type === 'FirstRows' ? numFirst : numRandom;
        let isValid = value >= 1 && value <= maxValue;
        setIsValid(isValid);
    }, [type, numFirst, numRandom, maxValue]);

    const onNumFirstChanged = (e) => {
        setNumFirst(e.target.value);
    };

    const onNumRandomChanged = (e) => {
        setNumRandom(e.target.value);
    };

    const confirm = () => {
        if (isValid) {
            let value = type === 'FirstRows' ? numFirst : numRandom;
            props.onConfirm(type, value);
        }
    };

    return (
        <div className={styles.export}>
            <div className={styles.modal}>
                <div className={styles.header}>
                    <button className={styles.close} type="button" onClick={props.onClose}><img src={closeIcon} alt='Close' /></button>
                    <img className={styles.icon} src={exportIcon} alt='Export' />
                    <h1>{t('shared.exportTitle')}</h1>
                </div>
                <div className={styles.content}>
                    <div className='row'>
                        <div className='col'>{t('shared.exportTotal', { total: allResults })}</div>
                    </div>
                    <div className='row'>
                        <div className='col'><input type='radio' value='FirstRows' checked={type === 'FirstRows'} onChange={e => setType(e.target.value)} /> {t('shared.exportFirst')} <input type='number' value={numFirst} onChange={onNumFirstChanged} min='1' max={maxValue} /> {t('shared.exportRecords')}</div>
                    </div>
                    <div className='row'>
                        <div className='col'><input type='radio' value='RandomRows' checked={type === 'RandomRows'} onChange={e => setType(e.target.value)} /> {t('shared.exportRandom')} <input type='number' value={numRandom} onChange={onNumRandomChanged} min='1' max={maxValue} /> {t('shared.exportRecords')}</div>
                    </div>
                    {!isValid && <div className='row'><div className='col'>{t('shared.exportMax', { max: maxValue })}</div></div>}
                </div>
                <div className={styles.actions}>
                    <button type="button" onClick={confirm}>{t('shared.export')}</button>
                </div>
            </div>
        </div>
    );
};

export default ResultsExport;