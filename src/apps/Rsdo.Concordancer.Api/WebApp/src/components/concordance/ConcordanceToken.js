import styles from './ConcordanceToken.module.scss';

const ConcordanceToken = (props) => {
    if (props.isCenterMatch === true) {
        return <span className={styles.center}>{props.content}</span>
    } else if (props.isWordInContextMatch === true) {
        return <em className={styles.wordInContext}>{props.content}</em>
    } else {
        return <>{props.content}</>
    }
};

export default ConcordanceToken;

