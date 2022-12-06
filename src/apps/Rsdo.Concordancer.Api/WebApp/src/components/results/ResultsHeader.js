import exportIcon from '../../assets/export.svg';
import styles from './ResultsHeader.module.scss';

const ResultsHeader = (props) => {
    return (
        <div className={`row ${styles.resultsHeader}`}>
            <div className='col'><h1>{props.query}</h1></div>
            <div className='col text-end'><button type='button' className='btn btn-link' onClick={props.onExport}><img src={exportIcon} alt='Export' /></button></div>
        </div>
    );
};

export default ResultsHeader;