import styles from './ConcordanceDetailsTextInfo.module.scss';

const ConcordanceDetailsTextInfo = (props) => {
    var title = props.title;
    var value = props.value;

    if (value) {
        return (<div className={styles.textInfo}>
            <h5>{title}</h5>
            <p>{value}</p>
        </div>);
    }
};

export default ConcordanceDetailsTextInfo;